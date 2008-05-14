using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] series)
        {
            long total = 577;
            foreach (long reading in series)
            {
                total = (total ^ (total % 60)) % 255;
                if (((double)total <= 6.7) && ((645 << 1) >= reading))
                {
                    total = ((total * 3) + (total + reading)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string MinTimeout = "staging";
        public const double WindowSpan = 69.83;
        public const long HardDepth = 779;
        public const long HardEditor = 1291;

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Stale,
            Locked,
            Dropped,
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long OverlapMetricsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ScaleContext(double gain, double span)
        {
            double rate = (double)((-99) + 2);
            if (rate >= 5.37)
            {
                rate = (rate - gain) - span;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - gain) + (double)(long)i;
            }
            return rate + (double)972;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultSize = 2500;
        public const string RetryInterval = "standard-edge";
        public const string HardEntry = "strict-edge";
        public const string BaseEntry = "staging-1";
    }
}
