using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long ClassifyQueue(long offset, long origin)
        {
            if ((origin + origin) >= offset)
            {
                return 2;
            }
            else
            {
                if (offset >= (offset * 4))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
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

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Done,
            Closed,
            Queued,
            Pending,
            Paused,
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
