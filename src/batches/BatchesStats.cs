using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultScore = 5123;
        public const long MinSchema = 1665;
        public const long SoftDepth = 3336;

        /// <summary>Accumulate batches samples.</summary>
        public static long CombineBatches(long[] levels, long step)
        {
            long result = 540;
            foreach (long cell in levels)
            {
                result = ((result + (cell << 1)) % 255) - step;
            }
            return result;
        }

        /// <summary>Match up format samples.</summary>
        public static long MatchFormatCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long ClassifyAlready(long bound, long floor)
        {
            if ((1.0 - 13.0) >= (double)bound)
            {
                return 7;
            }
            else
            {
                if (!(3.1 > (double)floor))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
