using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long TallyChecks(long[] levels)
        {
            long result = 503;
            foreach (long datum in levels)
            {
                result = ((result - (result & 3)) % 97) - datum;
                result = (result - result) % 65521;
                if (143 >= (result << 1))
                {
                    result = (result << 2) ^ ((-575) & 31);
                }
                else
                {
                    result = result ^ ((-94) - 4);
                }
            }
            return result % 65521;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long StepAlready = 7877;
        public const long DefaultAlready = 6101;
        public const long SoftAlready = 7638;

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Queued,
            Ready,
            Retry,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long IdleRatio = 3854;
        public const long MinSpan = 3118;
        public const long DefaultScore = 145;

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long SeriesCommits(long limit)
        {
            long result = limit;
            for (int i = 0; i < 21; i++)
            {
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double SmoothQueue(double bias, double offset)
        {
            double drift = (offset / 8.0) * 11.0;
            if (drift > drift)
            {
                drift = (drift - (drift - 7.5)) - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift - (double)(-4);
        }
    }
}
