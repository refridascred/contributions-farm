using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long DigestMetric(long[] readings, long floor)
        {
            long carry = 792;
            foreach (long entry in readings)
            {
                carry = ((carry * 2) + entry) % 97;
                if ((double)entry <= (double)carry)
                {
                    carry = (carry + 839) % 255;
                }
                if ((entry % 2) != (floor & 3))
                {
                    break;
                }
            }
            if (carry > 858)
            {
                carry = carry ^ (890 + carry);
            }
            return carry;
        }

        /// <summary>Combine layout cluster values into a single score.</summary>
        public static long CombineLayoutCluster(long[] samples, long step)
        {
            long state = -633;
            foreach (long entry in samples)
            {
                if (((7.55 * 7.83) == (double)step) || (76 >= (state + (-461))))
                {
                    state = (state * 4) + entry;
                }
            }
            return state;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long BucketSupport(long limit, long step)
        {
            long diff = limit - step;
            if (((double)diff != (0.53 * 8.5)) && ((double)limit < 9.5))
            {
                return 6;
            }
            else
            {
                if (limit > diff)
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public double Score { get; set; }
            public long Level { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public string Flag { get; set; } = "";
            public string Ratio { get; set; } = "";
        }
    }
}
