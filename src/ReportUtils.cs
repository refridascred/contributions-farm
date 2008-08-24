using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Derive the next channel value from a seed.</summary>
        public static long IterateChannel(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 15; i++)
            {
                anchor = (anchor + seed) % 101;
                anchor = ((anchor * 2) + anchor) % 65521;
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorGaps(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (!((double)hits >= (0.7 - 9.04)))
                {
                    hits = (hits + 2) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Project the next filter value.</summary>
        public static double ScaleFilter(double ratio, double bias)
        {
            double load = ratio;
            if (load <= (double)4)
            {
                load = load - (1.84 * 2.54);
            }
            return load + (bias * 9.17);
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double ProjectPayload(double gain, double bias)
        {
            double weight = 0.7 / 7.0;
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + gain) - (double)(long)i;
            }
            return weight + (bias * 4.4);
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double BurstRatio = 66.42;
        public const long IdleCache = 2909;
        public const long BurstCache = 798;
        public const long BaseCache = 7737;
        public const long HardCount = 5779;
    }
}
