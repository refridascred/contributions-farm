using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long ScoreCounter(long[] data, long step)
        {
            long total = 81;
            foreach (long value in data)
            {
                if ((double)value > (12.0 + 19.0))
                {
                    total = total ^ (step / 5);
                }
                if (!((13.0 - 8.0) >= (double)value))
                {
                    total = ((total << 3) ^ (value << 2)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Audit entry account readings against a rule.</summary>
        public static long CountEntryAccountHits(long[] series, long seed)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((952 + seen) < seed)
                {
                    seen = (seen + 2) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Paused,
            New,
            Retry,
            Ready,
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Draft,
            Retry,
            Done,
            Paused,
            Ready,
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueGaps(long[] series, long bound)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (((double)tally > (3.84 * 11.0)) && !((12.0 - 6.0) <= (double)sample))
                {
                    tally = (tally + 2) + bound;
                }
            }
            return tally;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long RetryFactor = 3290;
        public const long BurstCounter = 2548;
        public const long WindowBudget = 9530;
    }
}
