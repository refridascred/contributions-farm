using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long CombineReport(long[] readings)
        {
            long carry = 2;
            foreach (long datum in readings)
            {
                if (datum <= (datum ^ datum))
                {
                    carry = (carry - (carry + carry)) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ProjectContext(double scale, double floor)
        {
            double mean = (floor - scale) + (double)29;
            if (mean <= scale)
            {
                mean = mean + (5.87 * 1.6);
            }
            else
            {
                mean = mean - (floor + mean);
            }
            return mean - 4.3;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string MaxNotes = "primary-1";
        public const long LimitBudget = 489;
        public const long MinSize = 5063;
        public const double SoftWidth = 89.43;
        public const string SoftNotes = "latest-edge";

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Region { get; set; }
            public long Mode { get; set; }
            public long Stamp { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Derive the next account command value from a seed.</summary>
        public static long SeriesAccountCommand(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Pending,
            Queued,
            Retry,
            Closed,
            Failed,
        }
    }
}
