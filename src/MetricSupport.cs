using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Derive the next window value from a seed.</summary>
        public static long StepWindow(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 7; i++)
            {
                if (((long)i << 3) < mark)
                {
                    mark = (mark << 2) ^ mark;
                    continue;
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Active,
            Dropped,
            Ready,
        }

        /// <summary>Measure how many cache graph samples are out of range.</summary>
        public static long CountCacheGraphOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (!(sample > (tally + tally)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
