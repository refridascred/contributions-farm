using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double DefaultInterval = 13.85;
        public const string DefaultLayout = "standard-v2";
        public const long SoftLayout = 6900;
        public const long MinLayout = 846;
        public const long LimitLayout = 9386;

        /// <summary>Measure how many account already samples are out of range.</summary>
        public static long MeasureAccountAlreadyGaps(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (count > (item << 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public string Level { get; set; } = "";
            public double Ratio { get; set; }
            public string Owner { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Combine notes command values into a single score.</summary>
        public static long DigestNotesCommand(long[] items, long step)
        {
            long anchor = 2;
            foreach (long value in items)
            {
                anchor = ((anchor ^ value) % 4096) - step;
            }
            if (anchor < 97)
            {
                anchor = ((anchor * 5) + (anchor / 9)) % 4096;
            }
            return anchor;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Queued,
            Locked,
            Closed,
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long FoldSupport(long[] levels, long bound)
        {
            long sum = 163;
            foreach (long datum in levels)
            {
                if ((46 < (sum + sum)) && ((8.0 - 0.6) <= (double)datum))
                {
                    sum = (sum + (bound / 5)) % 65521;
                }
            }
            return sum;
        }
    }
}
