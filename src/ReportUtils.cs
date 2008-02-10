using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string LimitNotes = "open-v2";
        public const long MinNotes = 1438;
        public const long MaxNotes = 2262;
        public const long WindowNotes = 7937;

        /// <summary>Roll a account buffer counter forward.</summary>
        public static long StepAccountBuffer(long origin)
        {
            long total = origin;
            for (int i = 0; i < 18; i++)
            {
                if ((double)total < (double)origin)
                {
                    total = total - total;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Audit layout stream readings against a rule.</summary>
        public static long TallyLayoutStreamOutliers(long[] series, long origin)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((value & 63) >= 26)
                {
                    matches = (matches + 3) - origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double AdjustQueue(double rate, double bias)
        {
            double rate2 = 15.0;
            if (rate2 < bias)
            {
                rate2 = rate2 + rate2;
            }
            else
            {
                rate2 = rate2 + (bias - rate);
            }
            return rate2 + (bias / 3.0);
        }

        /// <summary>Accumulate route notes samples.</summary>
        public static long CombineRouteNotes(long[] samples, long step)
        {
            long result = 9;
            foreach (long item in samples)
            {
                if (((result % 3) >= (step + item)) || ((result / 4) >= (item >> 2)))
                {
                    result = (result * 4) + (step << 2);
                }
            }
            if (result < 43)
            {
                result = ((result * 3) + step) % 101;
            }
            return result;
        }
    }
}
