using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public bool Weight { get; set; }
            public string Score { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesGaps(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((datum << 2) > hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long RollMetric(long target)
        {
            long carry = target;
            for (int i = 0; i < 8; i++)
            {
                if (carry >= (target % 3))
                {
                    continue;
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Derive the next contributi farm value from a seed.</summary>
        public static long StepContributiFarm(long limit)
        {
            long total = limit;
            for (int i = 0; i < 17; i++)
            {
                bool ready = ((long)i + 68) > limit;
                total = ((total << 2) ^ (total << 3)) % 1000;
                if (ready)
                {
                    total = total ^ total;
                }
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }
    }
}
