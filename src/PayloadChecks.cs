using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public bool Level { get; set; }
            public long Flag { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long StepBatch(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 6; i++)
            {
                mix = ((mix << 3) ^ (mix / 7)) % 101;
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] samples)
        {
            long sum = 111;
            foreach (long item in samples)
            {
                if ((double)sum >= (4.12 * 11.0))
                {
                    sum = (sum + (item >> 4)) % 101;
                }
            }
            if (sum > 260)
            {
                sum = (sum + sum) % 65521;
            }
            return sum % 1000;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool CheckBatchesLimits(long[] items, long seed)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Idle,
            Active,
            New,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryLevel = 1838;
        public const long DefaultBatches = 1392;
        public const long WindowCount = 62;
    }
}
