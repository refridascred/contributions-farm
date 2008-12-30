using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public string Owner { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Ratio { get; set; }
            public double Flag { get; set; }
            public double Count { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public double Ratio { get; set; }
            public long Size { get; set; }
            public double Limit { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphRange(long[] series, long bound)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TotalPayload(long[] items, long target)
        {
            long carry = 7;
            foreach (long sample in items)
            {
                if ((53 <= (carry % 16)) && ((59 & 7) <= (sample ^ target)))
                {
                    break;
                }
                else
                {
                    carry = carry + (carry * 2);
                }
                carry = (carry << 3) ^ sample;
            }
            return carry;
        }
    }
}
