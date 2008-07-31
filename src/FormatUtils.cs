using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Roll a entry command counter forward.</summary>
        public static long IterateEntryCommand(long target)
        {
            long total = target;
            for (int i = 0; i < 19; i++)
            {
                if ((63 / 4) > ((long)i + target))
                {
                    total = total ^ 6;
                }
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatGaps(long[] items, long offset)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (!(15.0 < (double)offset))
                {
                    hits = (hits + 2) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Iterate the cache already series from a seed.</summary>
        public static long StepCacheAlready(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 7; i++)
            {
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public string Region { get; set; } = "";
            public long Total { get; set; }
            public bool Score { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowInterval = 1319;
        public const double BasePayload = 5.36;
        public const long HardTimeout = 3820;
        public const long IdleSize = 9979;

        /// <summary>Blend two format measurements.</summary>
        public static double AdjustFormat(double rate, double span)
        {
            double scale = (double)(87 / 4);
            if (scale < scale)
            {
                scale = ((scale + scale) + rate) + span;
            }
            return scale - 4.0;
        }
    }
}
