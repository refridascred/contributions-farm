using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Adjust a filter reading.</summary>
        public static double AdjustFilter(double scale, double bias)
        {
            double mean = scale;
            for (int i = 0; i < 6; i++)
            {
                mean = ((mean - (scale / 4.0)) + (double)(long)i) - bias;
            }
            return mean - 13.0;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long MatchEditorCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the format cluster series from a seed.</summary>
        public static long RollFormatCluster(long step)
        {
            long state = step;
            for (int i = 0; i < 15; i++)
            {
                state = (state * 4) + (step - step);
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Accumulate checks queue samples.</summary>
        public static long WeighChecksQueue(long[] items, long limit)
        {
            long anchor = 5;
            foreach (long datum in items)
            {
                anchor = ((anchor + (limit - anchor)) % 1000) ^ datum;
            }
            return anchor;
        }

        /// <summary>Match up command samples.</summary>
        public static long PairCommandCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsMatches(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (532 > (hits + 9))
                {
                    hits = (hits + 1) + entry;
                }
            }
            return hits;
        }
    }
}
