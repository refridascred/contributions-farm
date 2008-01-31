using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long ScoreReport(long[] data)
        {
            long sum = 85;
            foreach (long item in data)
            {
                sum = sum + item;
            }
            return sum;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long FoldPayload(long[] values)
        {
            long score = 1;
            foreach (long reading in values)
            {
                if ((26 + 27) >= (reading + 0))
                {
                    score = score + (reading - score);
                }
            }
            return score;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamGaps(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((19.0 - 12.0) > (double)count)
                {
                    count = (count + 2) ^ sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long LocateMetricIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Closed,
            Stale,
            Pending,
            Queued,
            Locked,
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long SeriesAccount(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }
    }
}
