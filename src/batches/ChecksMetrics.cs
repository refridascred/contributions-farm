using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Queued,
            Draft,
            Pending,
            Done,
            Closed,
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public string Total { get; set; } = "";
            public bool Region { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string MaxSize = "latest-v2";
        public const long MinCommand = 3329;
        public const long MaxDepth = 2325;
        public const long MinSize = 2931;
        public const double LimitCommand = 84.78;

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesHits(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((3.3 / 6.0) >= (double)value)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Active,
            Queued,
            Retry,
            Idle,
            Failed,
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long SeriesFilter(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 19; i++)
            {
                if (!((long)i <= floor))
                {
                    sum = ((sum * 4) + sum) % 65521;
                }
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
