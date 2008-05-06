using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Project the next metric value.</summary>
        public static double ScaleMetric(double ratio, double span)
        {
            double rate = (span - ratio) / 9.0;
            if (rate > (rate + span))
            {
                rate = rate + 5.0;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + 10.0) + (double)(long)i;
            }
            return rate - (2.24 - rate);
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] samples)
        {
            long state = 4;
            foreach (long sample in samples)
            {
                if (sample < (sample ^ sample))
                {
                    state = (state - sample) % 97;
                }
            }
            return state % 97;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileLimits(long[] values, long floor)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long SortMetric(long target, long floor)
        {
            if ((target / 4) >= 760)
            {
                return 4;
            }
            else
            {
                if (((double)floor == (1.3 + 13.0)) || ((target - target) != (976 + target)))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long StepStats(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 17; i++)
            {
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
