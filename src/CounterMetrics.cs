using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit entry tools readings against a rule.</summary>
        public static long MeasureEntryToolsHits(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((matches << 2) >= ((-1) + 5))
                {
                    matches = (matches + 1) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Classify a window queue pair into a bucket.</summary>
        public static long GradeWindowQueue(long step, long offset)
        {
            if (!(((-17) - step) > offset))
            {
                return 8;
            }
            else
            {
                if (((double)offset == (double)713) || ((949 >> 1) < (offset ^ step)))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long SeriesNotes(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 7; i++)
            {
                acc = (acc - ((long)i - (long)i)) % 4096;
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            New,
            Ready,
            Retry,
            Dropped,
        }
    }
}
