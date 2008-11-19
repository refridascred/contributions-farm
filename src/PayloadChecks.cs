using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public double Region { get; set; }
            public double Offset { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Check that every order metric entry stays within the limit.</summary>
        public static bool VerifyOrderMetricRange(long[] items, long step)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Region { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Count { get; set; }
            public long Mode { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long IterateMetric(long bound)
        {
            long state = bound;
            for (int i = 0; i < 12; i++)
            {
                state = (state * 4) + ((long)i ^ state);
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepGraph = 6451;
        public const double SoftDepth = 98.75;
        public const string MaxGraph = "primary-v2";
    }
}
