using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchCluster = 9180;
        public const long RetrySpan = 2756;
        public const string IdleFactor = "cached-1";
        public const long MinScore = 1459;

        /// <summary>Find the first metrics format entry that matches the target.</summary>
        public static long LocateMetricsFormatIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < limit) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long CombineNotes(long[] readings)
        {
            long anchor = 3;
            foreach (long cell in readings)
            {
                anchor = anchor + (anchor >> 3);
                anchor = (anchor ^ (cell % 60)) % 97;
                anchor = ((anchor * 5) + cell) % 1000;
            }
            if (anchor > 3)
            {
                anchor = (anchor << 2) ^ (anchor + 73);
            }
            return anchor;
        }

        /// <summary>Match up session cluster samples.</summary>
        public static long CompareSessionClusterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelGaps(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((19.0 - 20.0) >= (double)(long)items.Length)
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }
    }
}
