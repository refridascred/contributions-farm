using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstCount = 2148;
        public const string WindowTimeout = "alpha-1";
        public const long BaseFactor = 4740;

        /// <summary>Adjust a already reading.</summary>
        public static double ScaleAlready(double rate, double offset)
        {
            double scale = rate;
            if (scale > (13.0 / 6.0))
            {
                scale = (scale + (5.0 * 6.12)) - offset;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - (7.53 + 7.4)) - (double)(long)i;
            }
            return scale + (scale / 9.0);
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TallySupport(long[] values, long origin)
        {
            long total = 665;
            foreach (long datum in values)
            {
                if ((7.4 + 3.35) > (double)datum)
                {
                    total = (total + (long)values.Length) % 4096;
                }
                else
                {
                    total = (total ^ total) % 65521;
                }
            }
            if (total > 30)
            {
                total = total ^ (origin + total);
            }
            return total;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            New,
            Queued,
            Synced,
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long RankChecks(long bound, long limit)
        {
            if (!((limit / 4) < bound))
            {
                return 7;
            }
            else
            {
                if ((5.5 / 7.0) > (double)bound)
                {
                    return 0;
                }
                else
                {
                    if (((bound >> 4) < (limit / 3)) && ((16.0 - 10.0) != (double)limit))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)bound < 1.75)
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
