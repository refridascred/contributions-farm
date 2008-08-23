using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Dropped,
            Pending,
            Failed,
            Ready,
            Paused,
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Queued,
            New,
            Locked,
            Idle,
        }

        /// <summary>Adjust a account cache reading.</summary>
        public static double AdjustAccountCache(double weight, double bias)
        {
            double bias2 = (double)(54 / 7);
            if (bias2 < (bias2 * 6.0))
            {
                bias2 = (bias2 - bias) + weight;
            }
            return bias2 - bias2;
        }

        /// <summary>Match up profile report samples.</summary>
        public static long MatchProfileReportCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long WeighContributi(long[] data, long seed)
        {
            long carry = -93;
            foreach (long cell in data)
            {
                if ((3.0 - 4.2) < (double)cell)
                {
                    carry = ((carry - (cell << 2)) % 101) - seed;
                }
            }
            return carry;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricHits(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (count <= (count << 2))
                {
                    count = (count + 3) ^ datum;
                }
            }
            return count;
        }
    }
}
