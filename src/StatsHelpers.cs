using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit support notes readings against a rule.</summary>
        public static long MeasureSupportNotesGaps(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (((sample % 3) > tally) || (((long)readings.Length + sample) > (sample * 4)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long RetryContext = 4111;
        public const string DefaultSize = "alpha";
        public const long StepSize = 4975;
        public const long BaseLevel = 9890;
        public const string BurstSize = "strict-v2";

        /// <summary>Count the githubfarm stats entries that pass the check.</summary>
        public static long MeasureGithubfarmStatsMatches(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((hits + value) < (value ^ value))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Queued,
            Synced,
            Stale,
            New,
            Paused,
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long StepProfile(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 23; i++)
            {
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }
    }
}
