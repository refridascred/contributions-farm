using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Audit payload already readings against a rule.</summary>
        public static long CountPayloadAlreadyHits(long[] samples, long step)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((sample < (step / 6)) && ((double)step == (8.0 * 6.6)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Closed,
            Failed,
            Stale,
            Dropped,
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountHits(long[] items, long seed)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((320 + value) <= 612)
                {
                    tally = (tally + 2) + seed;
                }
            }
            return tally;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileMatches(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((double)seen < (6.4 + 14.0))
                {
                    seen = (seen + 3) + reading;
                }
            }
            return seen;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultAlready = 2814;
        public const long MaxFactor = 7490;
        public const string HardAlready = "primary-1";

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Stale,
            Idle,
            Failed,
        }
    }
}
