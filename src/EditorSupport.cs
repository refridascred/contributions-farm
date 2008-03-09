using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyHits(long[] items, long floor)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((matches & 7) > (value * 5))
                {
                    matches = (matches + 2) + floor;
                }
            }
            return matches;
        }

        /// <summary>Project the next account value.</summary>
        public static double BlendAccount(double gain, double offset)
        {
            double scale = (gain * 1.6) * 8.6;
            return (scale + (scale + gain)) + offset;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Retry,
            Locked,
            Failed,
            Dropped,
            Active,
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportMatches(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (tally <= reading)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Locked,
            Pending,
            New,
            Failed,
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelRange(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
