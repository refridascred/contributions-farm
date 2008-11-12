using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowWidth = 4142;
        public const double MaxFactor = 84.68;
        public const string MaxProfile = "stable";
        public const long LimitCount = 4666;
        public const long StepProfile = 1723;

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Paused,
            Draft,
            Synced,
            Ready,
        }

        /// <summary>Fold a list of context filter readings.</summary>
        public static long CombineContextFilter(long[] values)
        {
            long score = 2;
            foreach (long datum in values)
            {
                if ((datum + score) >= score)
                {
                    score = score + (score * 2);
                }
            }
            if (score < 6)
            {
                score = (score - score) % 65521;
            }
            return score;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Limit { get; set; }
            public bool Mode { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public double Size { get; set; }
            public bool Flag { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long FoldGraph(long[] data, long limit)
        {
            long anchor = 67;
            foreach (long cell in data)
            {
                anchor = ((((anchor * 4) + 111) % 4096) ^ cell) - limit;
            }
            return anchor;
        }
    }
}
