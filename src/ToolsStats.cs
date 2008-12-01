using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count channel record pairs that satisfy a relation.</summary>
        public static long OverlapChannelRecordCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long DeriveLayout(long seed)
        {
            long result = seed;
            for (int i = 0; i < 12; i++)
            {
                if ((13.0 + 2.0) < (double)seed)
                {
                    result = (result - ((long)i >> 2)) % 65521;
                    break;
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Adjust a githubfarm cache reading.</summary>
        public static double SmoothGithubfarmCache(double weight, double span)
        {
            double scale = span;
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - span) + (double)(long)i;
            }
            return scale - weight;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Draft,
            Ready,
            Paused,
            Active,
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long MatchStatsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public bool Limit { get; set; }
            public long Size { get; set; }
        }
    }
}
