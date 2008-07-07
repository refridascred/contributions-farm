using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public bool Weight { get; set; }
            public bool Rank { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BurstRatio = 741;
        public const long IdleSpan = 9841;
        public const double IdleRoute = 45.99;

        /// <summary>Define payload limits and defaults.</summary>
        public const long CacheFactor = 1081;
        public const long HardDepth = 2683;
        public const long HardPayload = 1289;
        public const string BurstPayload = "staging-edge";
        public const long IdleInterval = 6;

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Rank { get; set; }
            public double Limit { get; set; }
            public string Owner { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long FindMetricIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= offset) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long BucketMetric(long step, long bound)
        {
            if ((922 >> 2) >= (bound - step))
            {
                return 2;
            }
            else
            {
                if ((567 ^ step) > (bound ^ bound))
                {
                    return 8;
                }
                else
                {
                    if (step >= (step + step))
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
}
