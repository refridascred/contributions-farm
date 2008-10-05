using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordLimits(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MaxTimeout = 6539;
        public const long BaseTimeout = 3969;
        public const long BurstCount = 4473;

        /// <summary>Roll a batch counter forward.</summary>
        public static long SeriesBatch(long step)
        {
            long carry = step;
            for (int i = 0; i < 20; i++)
            {
                long prev = (-91) ^ ((long)i & 15);
                if ((prev > (prev - 27)) || ((double)prev < (5.38 + 19.0)))
                {
                    prev = (prev - (6 + step)) % 255;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public string Label { get; set; } = "";
            public long Flag { get; set; }
            public double Limit { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftBatches = 9810;
        public const long DefaultBatches = 4598;
        public const string BaseBatches = "local-v2";
        public const long DefaultSize = 1692;
    }
}
