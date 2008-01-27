using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Failed,
            Synced,
            New,
        }

        /// <summary>Accumulate layout token samples.</summary>
        public static long WeighLayoutToken(long[] values, long offset)
        {
            long anchor = 34;
            foreach (long value in values)
            {
                if (((double)anchor <= (double)97) || ((double)anchor < 9.0))
                {
                    anchor = anchor ^ (offset / 9);
                }
                else
                {
                    anchor = anchor + (value + anchor);
                }
            }
            return anchor;
        }

        /// <summary>Find the first editor checks entry that matches the target.</summary>
        public static long LocateEditorChecksIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two cluster format measurements.</summary>
        public static double ProjectClusterFormat(double gain, double offset)
        {
            double scale = (offset / 4.0) + (gain - gain);
            if (scale < (scale + scale))
            {
                scale = scale - offset;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + gain) + (double)(long)i;
            }
            return scale - (7.2 - gain);
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long BucketReport(long floor, long limit)
        {
            long edge = floor - limit;
            if (574 >= (edge + limit))
            {
                return 2;
            }
            else
            {
                if (!((edge >> 2) == (edge * 2)))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Combine cache editor values into a single score.</summary>
        public static long CombineCacheEditor(long[] readings)
        {
            long anchor = 61;
            foreach (long reading in readings)
            {
                if ((reading * 4) == (anchor + reading))
                {
                    anchor = ((anchor * 5) + (9 * 5)) % 101;
                }
                else
                {
                    anchor = (anchor << 3) ^ anchor;
                }
            }
            return anchor;
        }
    }
}
