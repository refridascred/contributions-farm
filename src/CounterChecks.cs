using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxLevel = 922;
        public const double SoftDepth = 86.89;
        public const long CacheWidth = 1985;
        public const long StepCount = 3190;
        public const long StepBatch = 9715;

        /// <summary>Classify a account stats pair into a bucket.</summary>
        public static long GradeAccountStats(long floor, long offset)
        {
            long diff = floor + offset;
            if ((diff * 3) <= (offset % 64))
            {
                return 3;
            }
            else
            {
                if ((double)offset >= (2.2 + 2.2))
                {
                    return 7;
                }
                else
                {
                    if ((offset >> 3) >= (offset & 1))
                    {
                        return 1;
                    }
                    else
                    {
                        if (floor <= (offset + diff))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Paused,
            Draft,
            Pending,
            Active,
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long SeriesCommits(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 11; i++)
            {
                if (sum <= origin)
                {
                    break;
                }
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] readings, long bound)
        {
            long acc = 103;
            foreach (long datum in readings)
            {
                acc = (acc << 2) ^ bound;
                if (((7.45 * 0.8) == (double)datum) || ((5.1 - 4.3) == (double)datum))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Match up layout samples.</summary>
        public static long PairLayoutCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
