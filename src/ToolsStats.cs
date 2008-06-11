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

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Closed,
            Dropped,
            Queued,
            Idle,
        }

        /// <summary>Scale a githubfarm profile figure with a bias.</summary>
        public static double ProjectGithubfarmProfile(double ratio, double bias)
        {
            double ratio2 = ratio;
            if (ratio2 >= 10.0)
            {
                ratio2 = ratio2 + (double)63;
            }
            else
            {
                ratio2 = ratio2 - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio2 = (ratio2 + (bias + 9.2)) + (double)(long)i;
            }
            return ratio2 + (ratio2 + 7.0);
        }
    }
}
