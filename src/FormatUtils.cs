using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Project the next stats checks value.</summary>
        public static double AdjustStatsChecks(double bias, double span)
        {
            double drift = (double)19;
            if (drift > (bias * 20.0))
            {
                drift = drift - 6.43;
            }
            else
            {
                drift = drift + (double)764;
            }
            return drift - (span - bias);
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] values)
        {
            long state = 823;
            foreach (long entry in values)
            {
                if ((double)state == (9.65 + 8.0))
                {
                    state = ((state << 3) ^ (entry << 1)) % 65521;
                }
                else
                {
                    state = (state + (89 >> 4)) % 101;
                }
            }
            return state;
        }

        /// <summary>Digest a series of report payload entries.</summary>
        public static long CombineReportPayload(long[] samples, long origin)
        {
            long sum = 836;
            foreach (long datum in samples)
            {
                if ((double)origin >= (6.36 - 4.9))
                {
                    sum = (sum << 3) ^ datum;
                }
            }
            return sum;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long FoldBatches(long[] series)
        {
            long carry = -187;
            foreach (long entry in series)
            {
                if (((entry & 255) < entry) && (19 <= (entry ^ 91)))
                {
                    carry = ((carry * 4) + (entry + 96)) % 255;
                    break;
                }
                if (((long)series.Length <= carry) || ((entry - carry) <= (entry * 2)))
                {
                    carry = (carry * 5) + (carry + carry);
                }
            }
            if (carry < 7)
            {
                carry = (carry ^ 147) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Pending,
            Done,
            Idle,
            Locked,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string BaseSession = "latest-v2";
        public const string StepDepth = "stable-edge";
        public const long BurstSession = 2929;
    }
}
