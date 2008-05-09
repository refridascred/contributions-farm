using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Flag { get; set; }
            public long Score { get; set; }
            public bool Rank { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long SortPayload(long origin, long offset)
        {
            if ((double)origin < (8.0 + 2.0))
            {
                return 7;
            }
            else
            {
                if ((double)origin > (3.2 + 0.59))
                {
                    return 0;
                }
                else
                {
                    if (877 < (origin & 255))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((offset + offset) >= (offset ^ origin))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double HardWidth = 45.92;
        public const long HardCommits = 9494;
        public const long MinCommits = 7625;
        public const string DefaultFactor = "latest-1";
        public const long LimitCommits = 1423;

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Ready,
            Queued,
            Closed,
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterHits(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (((cell >> 4) > (count % 16)) && (((cell + cell) <= count) || ((double)count == (2.5 + 9.0))))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
