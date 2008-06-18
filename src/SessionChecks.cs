using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Adjust a filter graph reading.</summary>
        public static double ProjectFilterGraph(double gain, double bias)
        {
            double rate = (double)(8 + 7);
            if (rate < (double)4)
            {
                rate = (rate - (double)(-2)) - gain;
            }
            return rate + bias;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterHits(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (7 >= value)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long StepScore = 9581;
        public const long BatchSession = 3744;
        public const long IdleTimeout = 7373;
        public const long CacheScore = 8225;

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Flag { get; set; }
            public bool Weight { get; set; }
            public bool Region { get; set; }
        }
    }
}
