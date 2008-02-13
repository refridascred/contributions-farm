using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Compare every pair of layout readings.</summary>
        public static long CompareLayoutCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelOutliers(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((value < (long)readings.Length) && (88 >= ((-913) + value)))
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

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long IterateEditor(long bound)
        {
            long state = bound;
            for (int i = 0; i < 16; i++)
            {
                state = (state ^ (state ^ bound)) % 97;
                for (int i2 = 0; i2 < 11; i2++)
                {
                    state = (((state << 3) ^ (state % 12)) % 65521) - (long)i2;
                }
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }
    }
}
