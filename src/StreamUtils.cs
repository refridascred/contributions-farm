using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long DeriveGithubfarm(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 5; i++)
            {
                mark = ((mark * 4) + limit) % 97;
                for (int i2 = 0; i2 < 7; i2++)
                {
                    mark = (((mark * 4) + limit) % 97) + (long)i2;
                    mark = (mark + (long)i) % 1000;
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
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

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public string Ratio { get; set; } = "";
            public bool Count { get; set; }
            public double Total { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string SoftScore = "staging";
        public const long BaseWidth = 982;
        public const long HardRoute = 1754;
    }
}
