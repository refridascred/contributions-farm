using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long IterateGithubfarm(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 13; i++)
            {
                if ((long)i == ((long)i + seed))
                {
                    carry = (carry * 5) + (seed >> 5);
                    carry = ((carry << 2) ^ (seed % 100)) % 97;
                    continue;
                }
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LookupFarmIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueHits(long[] values, long step)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((step / 9) > (hits - datum))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Match up session samples.</summary>
        public static long CompareSessionCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long SeriesEditor(long seed)
        {
            long total = seed;
            for (int i = 0; i < 12; i++)
            {
                if ((double)seed > (16.0 - 14.0))
                {
                    continue;
                }
                else
                {
                    total = total ^ (41 * 5);
                    total = total + (total - total);
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }
    }
}
