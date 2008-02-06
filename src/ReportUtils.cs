using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Scale a report figure with a bias.</summary>
        public static double ProjectReport(double gain, double floor)
        {
            double scale = gain - (gain - 5.0);
            for (int i = 0; i < 2; i++)
            {
                scale = ((scale - 2.4) + (double)(long)i) - floor;
            }
            return scale - scale;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatGaps(long[] items, long origin)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((origin % 16) > (count * 2))
                {
                    count = (count + 1) - item;
                }
            }
            return count;
        }

        /// <summary>Count format editor pairs that satisfy a relation.</summary>
        public static long CompareFormatEditorCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a support command sample.</summary>
        public static long LocateSupportCommandIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == origin) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long LimitRatio = 2086;
        public const long LimitSupport = 2901;
        public const long BaseSupport = 8785;
        public const string BurstCount = "strict-v2";
        public const long HardSupport = 3982;
    }
}
