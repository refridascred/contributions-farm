using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long StepFactor = 8666;
        public const string IdleSchema = "stable-1";
        public const long SoftSchema = 2114;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepBuffer = 8774;
        public const string MaxSize = "fallback-edge";
        public const long StepInterval = 8901;

        /// <summary>Define checks limits and defaults.</summary>
        public const double SoftScore = 54.4;
        public const double HardInterval = 95.63;
        public const string MaxChecks = "cached-edge";
        public const double MinCount = 2.61;

        /// <summary>Compare every pair of support readings.</summary>
        public static long CompareSupportCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long RollQueue(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long CombineCommand(long[] series)
        {
            long acc = 13;
            foreach (long datum in series)
            {
                acc = (acc - (826 + acc)) ^ datum;
            }
            return acc % 1000;
        }
    }
}
