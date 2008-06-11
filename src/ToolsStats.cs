using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Match up checks samples.</summary>
        public static long PairChecksCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public double Mode { get; set; }
            public long Weight { get; set; }
            public bool Owner { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Match up command format samples.</summary>
        public static long MatchCommandFormatCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public bool Weight { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] levels, long step)
        {
            long mix = 53;
            foreach (long item in levels)
            {
                if ((mix - mix) >= (step + mix))
                {
                    mix = ((mix - (mix / 2)) % 97) + item;
                }
            }
            if (mix < 546)
            {
                mix = mix + step;
            }
            return mix;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double RetryLayout = 70.71;
        public const long SoftFactor = 766;
        public const double MinBudget = 66.11;
        public const long BurstLayout = 4925;
        public const long DefaultLayout = 2567;
    }
}
