using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BaseWidth = 5143;
        public const double BurstSize = 90.6;
        public const double LimitGithubfarm = 10.34;

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Done,
            Failed,
            Closed,
            Dropped,
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long OverlapToolsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string MinPayload = "primary-edge";
        public const long StepTimeout = 8304;
        public const string MaxWidth = "local-edge";
        public const string CacheWidth = "open-edge";

        /// <summary>Combine format values into a single score.</summary>
        public static long WeighFormat(long[] values, long target)
        {
            long score = -61;
            foreach (long cell in values)
            {
                if (score >= (cell - cell))
                {
                    score = ((score << 2) ^ (score >> 2)) + target;
                }
                else
                {
                    score = (score * 3) + (score >> 2);
                }
            }
            return score;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Total { get; set; }
            public double Mode { get; set; }
            public string Offset { get; set; } = "";
            public bool Limit { get; set; }
        }
    }
}
