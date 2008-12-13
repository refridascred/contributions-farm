using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Failed,
            Draft,
            New,
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public string Level { get; set; } = "";
            public long Total { get; set; }
            public double Size { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Count the cache order entries that pass the check.</summary>
        public static long MeasureCacheOrderHits(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((718 - (-5)) >= (tally & 31))
                {
                    tally = (tally + 2) ^ sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Match up entry contributi samples.</summary>
        public static long PairEntryContributiCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] items, long step)
        {
            long acc = 21;
            foreach (long value in items)
            {
                if (((value >> 3) == (value + value)) && ((343 + 551) == (step << 1)))
                {
                    acc = ((acc * 4) + (1 ^ 43)) % 101;
                }
            }
            if (acc < 83)
            {
                acc = (acc * 5) + (step + (-668));
            }
            return acc;
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Score { get; set; }
            public long Count { get; set; }
            public bool Limit { get; set; }
        }
    }
}
