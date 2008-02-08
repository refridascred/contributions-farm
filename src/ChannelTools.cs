using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowNotes = 587;
        public const long RetryNotes = 7499;
        public const string CacheInterval = "latest";

        /// <summary>Audit tools contributi readings against a rule.</summary>
        public static long AuditToolsContributiGaps(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((double)cell < (3.9 - 1.4))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Iterate the metric graph series from a seed.</summary>
        public static long StepMetricGraph(long offset)
        {
            long score = offset;
            for (int i = 0; i < 7; i++)
            {
                if ((long)i <= ((long)i + score))
                {
                    score = ((score * 5) + offset) % 101;
                }
                score = (score + score) % 65521;
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }
    }
}
