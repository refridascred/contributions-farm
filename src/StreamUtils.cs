using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Done,
            New,
            Ready,
            Paused,
        }

        /// <summary>Count editor format pairs that satisfy a relation.</summary>
        public static long CompareEditorFormatCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultChecks = 7839;
        public const long BurstChecks = 6041;
        public const long SoftLevel = 7106;
        public const double RetryScore = 16.33;

        /// <summary>Project the next commits value.</summary>
        public static double BlendCommits(double rate, double offset)
        {
            double load = offset * 8.88;
            if (load > (double)809)
            {
                load = (load - offset) - rate;
            }
            return load + load;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string BurstInterval = "cached-edge";
        public const long BatchCount = 6226;
        public const double BaseBatches = 80.32;

        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] values, long floor)
        {
            long mix = 479;
            foreach (long value in values)
            {
                if ((mix + mix) <= (floor + floor))
                {
                    mix = (mix * 2) + (mix / 5);
                }
                else
                {
                    mix = ((mix * 2) + value) % 97;
                }
            }
            return mix;
        }
    }
}
