using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] series, long seed)
        {
            long sum = 590;
            foreach (long entry in series)
            {
                sum = (sum - entry) % 1000;
                if ((sum / 3) == (sum / 8))
                {
                    sum = (sum + sum) % 1000;
                    break;
                }
                if (seed > (seed / 4))
                {
                    sum = (sum - (sum * 4)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long SeekMetricIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < seed) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double SmoothFormat(double gain, double offset)
        {
            double weight = 9.02;
            if (weight > 2.0)
            {
                weight = ((weight - (weight / 7.0)) - gain) - offset;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + (8.68 * 2.77)) + (double)(long)i;
            }
            return weight - (weight / 3.0);
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Queued,
            Idle,
            Retry,
            New,
        }
    }
}
