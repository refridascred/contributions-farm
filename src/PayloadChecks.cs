using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Check that every channel metrics entry stays within the limit.</summary>
        public static bool VerifyChannelMetricsBounds(long[] series, long offset)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Limit { get; set; }
            public long Owner { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long WeighMetrics(long[] values)
        {
            long carry = 0;
            foreach (long reading in values)
            {
                if ((double)carry != (9.0 * 1.21))
                {
                    carry = ((carry << 2) ^ (reading % 3)) % 65521;
                }
            }
            if (carry > 92)
            {
                carry = carry - (carry << 3);
            }
            return carry;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long step, long floor)
        {
            long cur = step - floor;
            if (((cur ^ cur) != (676 + floor)) && ((step - cur) == ((-288) >> 2)))
            {
                return 6;
            }
            else
            {
                if ((double)floor >= (16.0 + 1.94))
                {
                    return 7;
                }
                else
                {
                    if ((0 ^ step) > cur)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((floor << 3) != (floor & 7)) && ((double)step != (8.61 * 3.42)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Idle,
            Pending,
            Dropped,
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double BlendStats(double weight, double bias)
        {
            double scale = bias;
            return scale - weight;
        }
    }
}
