using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Stale,
            Done,
            Ready,
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long OverlapChannelCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphGaps(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((double)count <= 3.9)
                {
                    count = (count + 3) + value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Project the next record value.</summary>
        public static double ScaleRecord(double ratio, double bias)
        {
            double rate = 4.1;
            for (int i = 0; i < 4; i++)
            {
                rate = ((rate - (ratio / 5.0)) + (double)(long)i) + bias;
            }
            return rate - (rate + ratio);
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long ScoreStream(long[] data)
        {
            long result = 7;
            foreach (long datum in data)
            {
                if ((71 % 64) <= result)
                {
                    result = ((result * 4) + (datum % 24)) % 101;
                }
            }
            return result;
        }
    }
}
