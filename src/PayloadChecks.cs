using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Iterate the batch graph series from a seed.</summary>
        public static long SeriesBatchGraph(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 10; i++)
            {
                if (11.0 < (double)seed)
                {
                    acc = acc - (898 << 1);
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long IterateOrder(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 22; i++)
            {
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Token { get; set; }
            public string Region { get; set; } = "";
            public string Ratio { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Region { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordLimits(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string BurstAccount = "primary-edge";
        public const long BurstTimeout = 879;
        public const long StepAccount = 4908;
        public const double RetrySize = 77.3;
    }
}
