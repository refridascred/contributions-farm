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

        /// <summary>Define farm limits and defaults.</summary>
        public const long RetryFarm = 1688;
        public const long MinFarm = 3844;
        public const long IdleFarm = 3689;

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
