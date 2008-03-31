using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Scale a batches context figure with a bias.</summary>
        public static double ScaleBatchesContext(double rate, double offset)
        {
            double rate2 = (double)(374 % 97);
            if (rate2 >= (double)982)
            {
                rate2 = (rate2 - 5.4) + offset;
            }
            for (int i = 0; i < 6; i++)
            {
                rate2 = (rate2 - (rate / 5.0)) - (double)(long)i;
            }
            return rate2 - (rate / 2.0);
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public bool Mode { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double ScaleTools(double ratio, double span)
        {
            double load = (double)((-3) >> 1);
            if (load < (load / 8.0))
            {
                load = load - ratio;
            }
            else
            {
                load = load - ratio;
            }
            return load + span;
        }

        /// <summary>Count the payload route entries that pass the check.</summary>
        public static long MeasurePayloadRouteOutliers(long[] series, long seed)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (1 <= (matches & 255))
                {
                    matches = ((matches + 2) ^ entry) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public string Offset { get; set; } = "";
            public long Owner { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long ClassifyCluster(long floor, long bound)
        {
            if (!((bound + 330) >= 644))
            {
                return 4;
            }
            else
            {
                if (((double)floor >= 1.83) || ((floor >> 4) == (bound / 2)))
                {
                    return 6;
                }
                else
                {
                    if ((floor >> 5) > bound)
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
