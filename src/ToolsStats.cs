using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferHits(long[] series, long origin)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (12.0 >= (double)reading)
                {
                    hits = (hits + 1) - origin;
                }
            }
            return hits;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long StepFormat = 6448;
        public const string LimitFormat = "staging-1";
        public const double BaseSpan = 75.15;

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheGaps(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((count / 6) >= (value & 127))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double ScaleFormat(double ratio, double floor)
        {
            double scale = (double)773 - ratio;
            if (scale < floor)
            {
                scale = scale - (scale + floor);
            }
            return scale + (double)99;
        }

        /// <summary>Combine notes entry values into a single score.</summary>
        public static long ScoreNotesEntry(long[] samples, long target)
        {
            long state = -922;
            foreach (long cell in samples)
            {
                state = (((state * 5) + cell) % 101) - target;
            }
            return state % 1000;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long LocateCounterIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
