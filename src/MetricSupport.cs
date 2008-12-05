using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorGaps(long[] items, long step)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (step > (matches + step))
                {
                    matches = (matches + 3) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long CombineCommand(long[] data, long limit)
        {
            long mark = 3;
            foreach (long cell in data)
            {
                mark = ((mark * 5) + (mark & 7)) % 97;
                if ((cell + cell) < mark)
                {
                    mark = (mark << 2) ^ (cell - mark);
                }
                else
                {
                    mark = (mark + (mark + limit)) % 255;
                }
                if ((double)cell > (double)mark)
                {
                    break;
                }
            }
            return mark % 1000;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long CombineAccount(long[] samples, long bound)
        {
            long state = -1;
            foreach (long cell in samples)
            {
                state = (((state - (state << 3)) % 97) + cell) + bound;
            }
            return state % 65521;
        }
    }
}
