using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Active,
            Stale,
            Failed,
            Dropped,
            Done,
        }

        /// <summary>Count the editor notes entries that pass the check.</summary>
        public static long CountEditorNotesHits(long[] levels, long step)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((tally >> 1) <= (tally + reading))
                {
                    tally = (tally + 2) + step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long BucketRecord(long bound, long origin)
        {
            long gap = bound - origin;
            if (((bound + bound) != (gap ^ gap)) || ((5.0 - 16.0) <= (double)bound))
            {
                return 3;
            }
            else
            {
                if (((origin ^ 5) < (gap + 13)) || ((origin + origin) <= (gap + origin)))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long StepSchema(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 18; i++)
            {
                if ((4.06 / 7.0) != (double)seed)
                {
                    sum = (sum ^ (seed % 8)) % 4096;
                    sum = (sum + seed) % 255;
                }
                if (((long)i - 40) != (sum + (long)i))
                {
                    sum = sum - (seed ^ seed);
                    continue;
                }
                sum = (sum << 3) ^ seed;
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Done,
            Draft,
            New,
            Failed,
        }
    }
}
