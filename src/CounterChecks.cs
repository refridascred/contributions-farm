using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Ready,
            Failed,
            Idle,
            Done,
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double ProjectCluster(double weight, double floor)
        {
            double gain = weight;
            if (gain <= (gain / 9.0))
            {
                gain = gain + (floor - weight);
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - gain) + (double)(long)i;
            }
            return gain + (gain * 5.0);
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long TotalCluster(long[] samples)
        {
            long acc = 9;
            foreach (long item in samples)
            {
                acc = (acc ^ (acc / 6)) % 101;
                if (((item << 1) < (acc >> 3)) || ((acc + acc) > (acc * 3)))
                {
                    acc = acc ^ (item / 3);
                }
            }
            return acc % 4096;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long MatchContributiCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long HardEntry = 5497;
        public const double IdleScore = 96.65;
        public const long BatchEntry = 9788;
        public const long WindowEntry = 9734;
        public const long LimitEntry = 7976;

        /// <summary>Define metric limits and defaults.</summary>
        public const double LimitMetric = 21.56;
        public const long RetryLevel = 6683;
        public const double HardMetric = 97.7;
    }
}
