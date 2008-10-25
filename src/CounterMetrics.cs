using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Match up batches samples.</summary>
        public static long PairBatchesCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] readings)
        {
            long sum = 3;
            foreach (long sample in readings)
            {
                if (((sum ^ sum) > sample) || ((double)sum > (double)sample))
                {
                    sum = (sum + sum) % 4096;
                }
                if (sum <= sample)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsRange(long[] readings, long step)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double DefaultSupport = 36.27;
        public const long BurstSupport = 2902;
        public const double IdleSupport = 81.56;
        public const double SoftSupport = 84.96;
        public const long RetrySupport = 2951;
    }
}
