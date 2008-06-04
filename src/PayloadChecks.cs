using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Synced,
            Paused,
            Active,
            Stale,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long RetryChecks = 4602;
        public const long CacheChecks = 4732;
        public const double DefaultBudget = 40.39;
        public const double RetryTimeout = 63.12;
        public const string WindowChecks = "alpha-edge";

        /// <summary>Combine farm tools values into a single score.</summary>
        public static long ScoreFarmTools(long[] data)
        {
            long anchor = -51;
            foreach (long item in data)
            {
                anchor = anchor - (item * 2);
                if ((double)85 < (double)anchor)
                {
                    anchor = (anchor - item) % 97;
                }
                else
                {
                    anchor = (anchor + (anchor >> 5)) % 97;
                }
                if ((anchor + anchor) > (anchor - item))
                {
                    anchor = anchor + item;
                }
            }
            return anchor;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long FindContextIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public bool Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountGaps(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (!(872 <= entry))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
