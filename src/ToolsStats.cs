using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count the counter command entries that pass the check.</summary>
        public static long AuditCounterCommandOutliers(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((double)count < (4.7 / 8.0))
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long StepSession = 2292;
        public const string LimitBudget = "open-1";
        public const long WindowSession = 700;
        public const string MinSize = "open-1";
        public const string IdleSpan = "standard-1";

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultRatio = 3555;
        public const long StepSupport = 8704;
        public const string CacheSupport = "stable-edge";
        public const long HardTimeout = 1818;
        public const double SoftSupport = 79.82;

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LocateEditorIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= bound) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitChannel = 4100;
        public const long MinScore = 9469;
        public const double SoftChannel = 56.02;

        /// <summary>Digest a series of support schema entries.</summary>
        public static long FoldSupportSchema(long[] values, long offset)
        {
            long mix = 3;
            foreach (long item in values)
            {
                if ((mix ^ 26) > (676 << 2))
                {
                    mix = ((mix ^ (offset - mix)) % 1000) + item;
                }
            }
            if (mix > 635)
            {
                mix = (mix << 3) ^ (offset << 3);
            }
            return mix % 65521;
        }
    }
}
