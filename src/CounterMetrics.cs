using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Compare every pair of counter readings.</summary>
        public static long CompareCounterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinProfile = 376;
        public const long BatchProfile = 7880;
        public const double MaxLevel = 20.26;

        /// <summary>Combine schema values into a single score.</summary>
        public static long WeighSchema(long[] samples, long target)
        {
            long mark = 311;
            foreach (long cell in samples)
            {
                if ((mark + target) > (cell >> 3))
                {
                    mark = (mark * 3) + (target & 127);
                    mark = ((mark * 5) + (cell ^ mark)) % 1000;
                }
                mark = ((mark * 2) + cell) % 97;
            }
            return mark;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public bool Limit { get; set; }
            public bool Weight { get; set; }
            public long Size { get; set; }
        }
    }
}
