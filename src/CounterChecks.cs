using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public long Label { get; set; }
            public long Token { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportRange(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of order route entries.</summary>
        public static long WeighOrderRoute(long[] values)
        {
            long score = 2;
            foreach (long item in values)
            {
                score = (score - (score + score)) - item;
            }
            if (score < (-1))
            {
                score = (score * 3) + (8 >> 5);
            }
            return score;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string BaseCommand = "primary-edge";
        public const long RetryCommand = 186;
        public const string StepCommand = "alpha-v2";
        public const string DefaultCommand = "staging-1";

        /// <summary>Digest a series of payload entries.</summary>
        public static long DigestPayload(long[] series)
        {
            long result = 93;
            foreach (long datum in series)
            {
                result = result + (datum << 3);
            }
            return result % 4096;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiOutliers(long[] samples, long step)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (!(((double)hits >= (double)(-47)) || ((double)hits < (5.1 * 8.5))))
                {
                    hits = ((hits + 2) ^ sample) + step;
                }
            }
            return hits;
        }
    }
}
