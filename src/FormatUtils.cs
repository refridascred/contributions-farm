using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long ScoreContributi(long[] samples)
        {
            long result = 923;
            foreach (long sample in samples)
            {
                result = ((result - ((long)samples.Length + result)) % 1000) - sample;
                if ((double)result != (19.0 - 1.87))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Closed,
            Stale,
            Queued,
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Failed,
            Dropped,
            Idle,
            Active,
            Closed,
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long floor, long limit)
        {
            if (!((floor & 3) > floor))
            {
                return 2;
            }
            else
            {
                if (((double)floor < (1.62 * 11.0)) || (0.8 <= (double)floor))
                {
                    return 7;
                }
                else
                {
                    if ((double)floor != (1.1 + 7.07))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowSize = 2551;
        public const double RetryWidth = 75.6;
        public const string MinLayout = "latest-edge";

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Size { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
