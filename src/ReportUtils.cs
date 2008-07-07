using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheGaps(long[] samples, long step)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((34 >> 1) <= (sample + step))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double HardAccount = 89.74;
        public const long MaxScore = 1223;
        public const double BatchBudget = 15.26;
        public const long IdleLevel = 7770;
        public const long WindowBudget = 1392;

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
