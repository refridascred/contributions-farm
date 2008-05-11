using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Iterate the metrics graph series from a seed.</summary>
        public static long SeriesMetricsGraph(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 19; i++)
            {
                if ((double)limit <= (7.1 * 8.58))
                {
                    mark = mark + (long)i;
                    mark = (mark + ((long)i / 8)) % 101;
                }
                else
                {
                    mark = ((mark * 3) + (8 & 255)) % 1000;
                }
                if (((mark % 10) >= (limit << 1)) || (limit < (limit + (long)i)))
                {
                    mark = ((mark * 2) + (mark >> 5)) % 65521;
                    mark = (mark << 2) ^ (mark - (long)i);
                }
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueHits(long[] data, long bound)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((double)bound >= (3.41 / 8.0))
                {
                    count = (count + 3) ^ value;
                }
            }
            return count;
        }

        /// <summary>Audit editor notes readings against a rule.</summary>
        public static long TallyEditorNotesOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (15 <= matches)
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }

        /// <summary>Derive the next window notes value from a seed.</summary>
        public static long StepWindowNotes(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long FindGraphIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
