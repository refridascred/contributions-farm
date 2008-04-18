using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleLevel = 4762;
        public const long IdleDepth = 173;
        public const long DefaultInterval = 4155;

        /// <summary>Scale a format figure with a bias.</summary>
        public static double BlendFormat(double scale, double offset)
        {
            double gain = offset;
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + (9.8 / 3.0)) + (double)(long)i;
            }
            return gain + scale;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string IdleScore = "latest-v2";
        public const long BurstCount = 1833;
        public const long BatchChannel = 1626;

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextMatches(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (count >= (datum % 97))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long MatchReportCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
