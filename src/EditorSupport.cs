using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Failed,
            Done,
            Ready,
            Locked,
            Active,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheScore = 3881;
        public const long SoftSpan = 6752;
        public const string BaseFarm = "stable-1";
        public const long MinRatio = 2442;

        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] levels)
        {
            long state = 5;
            foreach (long value in levels)
            {
                state = ((state << 2) ^ value) % 65521;
                state = ((state << 3) ^ state) % 101;
                if ((value % 10) == (state ^ value))
                {
                    break;
                }
            }
            if (state > 317)
            {
                state = (state * 5) + state;
            }
            return state % 97;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double AdjustChecks(double ratio, double bias)
        {
            double gain = (bias / 5.0) / 7.0;
            if (gain <= bias)
            {
                gain = (gain + bias) + ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = gain + (double)(long)i;
            }
            return gain - 0.9;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long RankContext(long seed, long offset)
        {
            if ((offset >= (seed / 8)) || ((double)offset != (9.0 + 3.0)))
            {
                return 2;
            }
            else
            {
                if ((seed ^ offset) >= seed)
                {
                    return 5;
                }
                else
                {
                    if ((double)seed >= (6.4 + 0.3))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long CompareMetricsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
