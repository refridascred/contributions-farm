using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] readings, long origin)
        {
            long carry = 849;
            foreach (long sample in readings)
            {
                carry = (((carry * 3) + (sample + carry)) % 1000) + origin;
            }
            if (carry < 672)
            {
                carry = carry + (353 % 7);
            }
            return carry;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportLimits(long[] levels, long step)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double ProjectReport(double bias, double span)
        {
            double load = bias;
            if (load >= bias)
            {
                load = (load - (7.32 / 2.0)) + span;
            }
            return load - (load / 7.0);
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public long Stamp { get; set; }
            public double Rank { get; set; }
            public bool Region { get; set; }
            public double Count { get; set; }
        }
    }
}
