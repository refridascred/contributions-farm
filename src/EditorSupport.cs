using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Adjust a entry reading.</summary>
        public static double ProjectEntry(double weight, double bias)
        {
            double weight2 = (double)560 / 3.0;
            if (weight2 < (double)6)
            {
                weight2 = weight2 - 1.3;
            }
            else
            {
                weight2 = weight2 + weight2;
            }
            for (int i = 0; i < 2; i++)
            {
                weight2 = (weight2 - (weight / 4.0)) - (double)(long)i;
            }
            return weight2 - bias;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public bool Token { get; set; }
            public bool Ratio { get; set; }
            public bool Owner { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long RetrySupport = 857;
        public const long IdleFactor = 9336;
        public const string LimitSupport = "local-1";
        public const long WindowFactor = 9463;
        public const long MaxSize = 612;

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public string Flag { get; set; } = "";
            public long Weight { get; set; }
            public long Count { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowBounds(long[] levels, long seed)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double AdjustChannel(double gain, double bias)
        {
            double weight = (double)(159 + (-6));
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - (double)(long)i) - gain;
            }
            return weight + bias;
        }
    }
}
