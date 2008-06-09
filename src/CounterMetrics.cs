using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Locate a commits reading by value.</summary>
        public static long SeekCommitsIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > limit) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit checks commits readings against a rule.</summary>
        public static long MeasureChecksCommitsOutliers(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (!(7 >= (count - count)) || !((reading - reading) >= reading))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long StepContext(long bound)
        {
            long result = bound;
            for (int i = 0; i < 17; i++)
            {
                result = result - result;
                result = (result ^ ((-288) >> 2)) % 255;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long FindAccountIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= target) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
