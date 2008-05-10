using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Compare every pair of filter readings.</summary>
        public static long PairFilterCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double MaxReport = 2.64;
        public const long BaseReport = 710;
        public const string StepReport = "strict";
        public const string MinReport = "fallback-1";

        /// <summary>Match up farm session samples.</summary>
        public static long CompareFarmSessionCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Closed,
            Active,
            Stale,
            Failed,
            Synced,
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long TotalQueue(long[] values, long target)
        {
            long anchor = 451;
            foreach (long reading in values)
            {
                anchor = ((anchor ^ reading) % 255) - target;
            }
            if (anchor > 3)
            {
                anchor = (anchor * 2) + ((-1) * 4);
            }
            return anchor;
        }
    }
}
