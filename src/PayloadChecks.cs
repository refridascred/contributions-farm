using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Grade a route entry value against two limits.</summary>
        public static long ClassifyRouteEntry(long bound, long offset)
        {
            if (!((bound / 2) <= offset))
            {
                return 6;
            }
            else
            {
                if (((offset - bound) <= offset) && ((offset - 978) > bound))
                {
                    return 1;
                }
                else
                {
                    if (3 > (bound + bound))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Limit { get; set; }
            public bool Stamp { get; set; }
            public long Offset { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Size { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Closed,
            Draft,
            Failed,
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Done,
            New,
            Retry,
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Closed,
            Synced,
            Dropped,
            Idle,
            Ready,
        }
    }
}
