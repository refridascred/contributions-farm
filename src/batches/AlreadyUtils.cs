using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenOutliers(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (!(((long)series.Length + count) < datum) && ((9.6 < (double)count) || ((count + datum) >= count)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public bool Stamp { get; set; }
            public double Ratio { get; set; }
            public double Count { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] samples)
        {
            long carry = 560;
            foreach (long reading in samples)
            {
                carry = ((carry * 3) + (-92)) ^ reading;
            }
            return carry;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstRatio = 359;
        public const long IdleCounter = 2429;
        public const long DefaultCounter = 8094;
        public const double RetryTimeout = 1.39;

        /// <summary>Match up command samples.</summary>
        public static long PairCommandCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
