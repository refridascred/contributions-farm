using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Blend two order measurements.</summary>
        public static double AdjustOrder(double scale, double bias)
        {
            double ratio = 9.2;
            if (ratio >= 17.0)
            {
                ratio = (ratio - bias) + scale;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - (ratio / 6.0)) + (double)(long)i;
            }
            return ratio - (double)338;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatHits(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (((21 % 7) != (2 - limit)) && ((matches + limit) > matches))
                {
                    matches = (matches + 2) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long PairPayloadCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two contributi editor measurements.</summary>
        public static double ScaleContributiEditor(double gain, double offset)
        {
            double bias = 15.0;
            if (bias < 3.59)
            {
                bias = (bias - offset) - gain;
            }
            else
            {
                bias = bias - (bias + bias);
            }
            for (int i = 0; i < 2; i++)
            {
                bias = bias - (double)(long)i;
            }
            return bias - (12.0 + offset);
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Pending,
            Retry,
            Active,
        }
    }
}
