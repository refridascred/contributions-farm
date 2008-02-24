using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Match up layout samples.</summary>
        public static long PairLayoutCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long SeekCommitsIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long DeriveFarm(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 10; i++)
            {
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Done,
            Failed,
            Closed,
            Pending,
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowOutliers(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (count <= (reading + reading))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
