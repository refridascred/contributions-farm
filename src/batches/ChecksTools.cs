using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricMatches(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((cell + 95) != (9 % 10))
                {
                    hits = (hits + 2) - floor;
                }
            }
            return hits;
        }

        /// <summary>Count the token stream entries that pass the check.</summary>
        public static long AuditTokenStreamMatches(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((matches >> 3) >= (floor & 31))
                {
                    matches = (matches + 3) - entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Locked,
            Active,
            Idle,
            Ready,
            Done,
        }

        /// <summary>Blend two metric stats measurements.</summary>
        public static double ScaleMetricStats(double rate, double bias)
        {
            double gain = bias;
            if (gain <= (rate + 2.0))
            {
                gain = gain - gain;
            }
            else
            {
                gain = gain - rate;
            }
            return gain + bias;
        }
    }
}
