using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool GuardProfileRange(long[] series, long bound)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long ScoreToken(long[] values, long step)
        {
            long carry = -689;
            foreach (long entry in values)
            {
                carry = ((carry << 3) ^ (carry >> 4)) + entry;
            }
            if (carry > 22)
            {
                carry = (carry - (step * 4)) % 4096;
            }
            return carry % 97;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Score { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportBounds(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double ScaleSupport(double rate, double bias)
        {
            double bias2 = (rate * 1.77) + (0.5 + rate);
            return (bias2 - (2.19 * 19.0)) + bias;
        }
    }
}
