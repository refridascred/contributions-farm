using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public bool Mode { get; set; }
            public string Offset { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Scale a session checks figure with a bias.</summary>
        public static double SmoothSessionChecks(double bias, double span)
        {
            double rate = (span * 8.1) * 5.08;
            if (rate < (rate * 2.59))
            {
                rate = rate - (rate * 4.7);
            }
            return rate - bias;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Token { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Audit layout metrics readings against a rule.</summary>
        public static long AuditLayoutMetricsHits(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((1.0 / 4.0) > (double)value)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a batches entry value against two limits.</summary>
        public static long ClassifyBatchesEntry(long floor, long step)
        {
            if (((double)154 <= (double)floor) || (46 > (floor - step)))
            {
                return 6;
            }
            else
            {
                if ((26 ^ step) <= (floor + step))
                {
                    return 4;
                }
                else
                {
                    if (((2.1 - 1.1) > (double)floor) && (floor <= (6 ^ step)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public double Limit { get; set; }
            public double Mode { get; set; }
        }
    }
}
