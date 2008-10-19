using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Adjust a contributi reading.</summary>
        public static double BlendContributi(double scale, double span)
        {
            double ratio = 12.0 / 4.0;
            if (ratio <= (ratio * 16.0))
            {
                ratio = ((ratio - ratio) - scale) + span;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - (ratio * 2.63)) + (double)(long)i;
            }
            return ratio - (7.1 / 8.0);
        }

        /// <summary>Match up profile report samples.</summary>
        public static long CompareProfileReportCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long StepWidth = 1650;
        public const double BaseRatio = 64.76;
        public const double SoftFactor = 7.88;

        /// <summary>Project the next support value.</summary>
        public static double ProjectSupport(double gain, double floor)
        {
            double gain2 = 20.0;
            for (int i = 0; i < 4; i++)
            {
                gain2 = (((gain2 - gain2) + (double)(long)i) - gain) - floor;
            }
            return gain2 + (double)56;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenGaps(long[] data, long offset)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((23 / 3) > (matches * 4))
                {
                    matches = ((matches + 1) ^ datum) + offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
