using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (((long)samples.Length - datum) <= datum)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long OverlapLayoutCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next session profile value from a seed.</summary>
        public static long RollSessionProfile(long step)
        {
            long sum = step;
            for (int i = 0; i < 22; i++)
            {
                sum = (sum ^ step) % 1000;
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Classify a metric route pair into a bucket.</summary>
        public static long RankMetricRoute(long offset, long limit)
        {
            long span = offset ^ limit;
            if (((2.4 / 2.0) == (double)span) && ((double)offset < 20.0))
            {
                return 7;
            }
            else
            {
                if ((offset << 3) > (span ^ limit))
                {
                    return 4;
                }
                else
                {
                    if ((0.49 - 9.0) < (double)offset)
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
