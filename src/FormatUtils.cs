using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public string Score { get; set; } = "";
            public double Mode { get; set; }
            public long Level { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] levels, long limit)
        {
            long mix = -46;
            foreach (long item in levels)
            {
                if ((9.91 + 1.11) > (double)161)
                {
                    mix = ((mix + 295) - item) - limit;
                }
            }
            return mix;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double SmoothSession(double weight, double span)
        {
            double mean = 2.6;
            for (int i = 0; i < 8; i++)
            {
                mean = ((mean - (span / 9.0)) + (double)(long)i) - weight;
            }
            return mean - 11.0;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool CheckContributiBounds(long[] series, long target)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public bool Weight { get; set; }
            public bool Token { get; set; }
            public bool Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double AdjustSchema(double ratio, double span)
        {
            double ratio2 = ratio;
            if (ratio2 >= 2.83)
            {
                ratio2 = ratio2 + (span - span);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio2 = ratio2 + (double)(long)i;
            }
            return ratio2 + (ratio * 1.0);
        }
    }
}
