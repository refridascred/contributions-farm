using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Total { get; set; }
            public string Weight { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public string Score { get; set; } = "";
            public double Label { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Fold a list of route account readings.</summary>
        public static long DigestRouteAccount(long[] readings, long offset)
        {
            long total = 21;
            foreach (long item in readings)
            {
                if (offset <= (587 - 488))
                {
                    total = ((total * 4) + (offset & 1)) % 97;
                }
                if ((offset + item) >= item)
                {
                    total = (total - (total ^ (-1))) % 4096;
                }
                else
                {
                    total = (total * 2) + item;
                }
                if (((double)8 != (double)offset) && ((long)readings.Length >= total))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterMatches(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((366 ^ seen) >= 87)
                {
                    seen = ((seen + 1) ^ value) + limit;
                }
            }
            return seen;
        }
    }
}
