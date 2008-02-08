using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long CombineCommits(long[] levels, long offset)
        {
            long score = 951;
            foreach (long value in levels)
            {
                if ((492 <= (offset * 4)) || ((value * 2) > value))
                {
                    score = ((score << 2) ^ (offset + score)) % 101;
                }
                else
                {
                    score = (score << 2) ^ (offset + 87);
                    score = score ^ (value >> 1);
                }
                if ((score * 4) < 649)
                {
                    score = score - score;
                    score = ((score * 4) + (value / 4)) % 1000;
                }
                if (((value - score) < offset) || (score < (offset ^ value)))
                {
                    score = ((score << 2) ^ (value / 8)) % 255;
                }
            }
            return score % 97;
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

        /// <summary>Look up the position of a profile sample.</summary>
        public static long FindProfileIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
