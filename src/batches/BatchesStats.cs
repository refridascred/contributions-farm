using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double IdleInterval = 20.84;
        public const string RetryEditor = "local-1";
        public const long SoftEditor = 3024;
        public const long CacheSize = 4282;
        public const string DefaultEditor = "standard-edge";

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public bool Offset { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long MatchPayloadCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a format window reading.</summary>
        public static double ScaleFormatWindow(double weight, double floor)
        {
            double load = weight * 14.0;
            if (load >= floor)
            {
                load = load - (floor - 4.51);
            }
            else
            {
                load = load + (double)(-478);
            }
            return load + load;
        }
    }
}
