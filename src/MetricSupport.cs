using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long ClassifyFormat(long origin, long seed)
        {
            if (3 >= (origin + origin))
            {
                return 8;
            }
            else
            {
                if (((origin >> 3) <= (origin ^ origin)) || ((25 & 31) == (origin ^ origin)))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardEditor = 7246;
        public const double SoftInterval = 54.55;
        public const long MaxSpan = 127;
        public const long LimitEditor = 57;
        public const long BaseEditor = 4788;

        /// <summary>Look up the position of a commits sample.</summary>
        public static long FindCommitsIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
