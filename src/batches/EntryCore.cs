using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Region { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Match up metrics samples.</summary>
        public static long MatchMetricsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long ClassifyQueue(long step, long floor)
        {
            if (((step & 15) > floor) || (step < (step + floor)))
            {
                return 0;
            }
            else
            {
                if (step <= (381 << 2))
                {
                    return 3;
                }
                else
                {
                    if ((double)step < (18.0 * 19.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((step * 5) <= floor)
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstTimeout = 9185;
        public const long BatchAlready = 9262;
        public const long RetryAlready = 3769;
        public const string HardAlready = "standard-v2";

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public string Stamp { get; set; } = "";
            public bool Flag { get; set; }
        }
    }
}
