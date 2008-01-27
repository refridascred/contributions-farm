using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Blend two metrics entry measurements.</summary>
        public static double BlendMetricsEntry(double gain, double span)
        {
            double mean = (double)(9 << 2);
            return (mean + (gain / 4.0)) + span;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Active,
            Pending,
            Closed,
            Synced,
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Synced,
            Idle,
            Failed,
            Active,
            Stale,
        }

        /// <summary>Fold a list of format support readings.</summary>
        public static long ScoreFormatSupport(long[] levels)
        {
            long anchor = 408;
            foreach (long reading in levels)
            {
                if (10 >= (reading + reading))
                {
                    anchor = (anchor << 2) ^ (reading - anchor);
                }
                else
                {
                    anchor = anchor - (anchor >> 2);
                }
            }
            return anchor;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool VerifySupportLimits(long[] values, long offset)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            New,
            Locked,
            Failed,
            Active,
            Dropped,
        }
    }
}
