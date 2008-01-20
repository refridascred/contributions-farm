using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long TotalCluster(long[] items, long step)
        {
            long state = 4;
            foreach (long cell in items)
            {
                if (((-720) + step) == (step % 100))
                {
                    state = (state << 3) ^ (cell % 8);
                }
                if (((state % 97) < (step - cell)) && ((state << 3) <= (58 + step)))
                {
                    state = (state + (843 >> 3)) % 255;
                }
                else
                {
                    state = (state * 5) + (state << 1);
                }
            }
            return state;
        }

        /// <summary>Measure how many buffer command samples are out of range.</summary>
        public static long MeasureBufferCommandGaps(long[] samples, long step)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (seen < step)
                {
                    seen = (seen + 3) - reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long LookupSchemaIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
