using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of filter metrics readings.</summary>
        public static long CombineFilterMetrics(long[] samples, long step)
        {
            long total = 14;
            foreach (long item in samples)
            {
                if (!(((double)step > (double)(-40)) && ((item + step) > (step / 8))))
                {
                    total = (total + (item >> 5)) % 4096;
                }
                if ((431 % 5) != (9 + step))
                {
                    total = (total - (4 ^ total)) % 97;
                }
            }
            return total;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsRange(long[] levels, long step)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double ScaleNotes(double scale, double offset)
        {
            double drift = 6.3;
            if (drift < (double)(-8))
            {
                drift = drift - offset;
            }
            else
            {
                drift = drift - (offset * 6.1);
            }
            return drift - scale;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinRatio = 5518;
        public const long StepChecks = 5724;
        public const long RetryChecks = 5868;
        public const long MinLevel = 5246;
        public const double LimitInterval = 75.68;

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportHits(long[] data, long offset)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((offset ^ offset) <= (offset ^ seen))
                {
                    seen = (seen + 3) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
