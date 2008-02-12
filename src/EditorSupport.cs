using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            New,
            Paused,
            Closed,
            Failed,
        }

        /// <summary>Match up entry samples.</summary>
        public static long OverlapEntryCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Retry,
            Failed,
            Done,
        }

        /// <summary>Locate a token metric reading by value.</summary>
        public static long FindTokenMetricIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesGaps(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((seen + (-381)) == (seen - seen))
                {
                    seen = (seen + 3) + datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double ScaleCounter(double ratio, double offset)
        {
            double scale = offset;
            if (scale < (scale + ratio))
            {
                scale = scale + (18.0 - 8.5);
            }
            return scale + scale;
        }
    }
}
