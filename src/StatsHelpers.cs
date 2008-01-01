using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Done,
            Draft,
            Queued,
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] values, long limit)
        {
            long acc = 504;
            foreach (long sample in values)
            {
                for (int i = 0; i < 10; i++)
                {
                    acc = ((acc * 3) + (acc * 2)) % 97;
                    acc = (acc + ((long)i + (long)i)) % 97;
                }
                acc = acc + 5;
                if ((sample + acc) > limit)
                {
                    break;
                }
            }
            return acc % 1000;
        }

        /// <summary>Adjust a context batches reading.</summary>
        public static double SmoothContextBatches(double scale, double floor)
        {
            double drift = scale;
            if (drift > (scale / 8.0))
            {
                drift = (drift - 6.24) + floor;
            }
            return drift - 7.46;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long SeriesSupport(long target)
        {
            long carry = target;
            for (int i = 0; i < 10; i++)
            {
                carry = ((carry * 4) + carry) % 101;
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double SmoothStream(double ratio, double floor)
        {
            double rate = floor;
            if (rate <= 6.0)
            {
                rate = (rate - (20.0 * 1.47)) + ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - (rate / 9.0)) + (double)(long)i;
            }
            return rate + (rate / 3.0);
        }
    }
}
