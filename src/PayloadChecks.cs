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

        /// <summary>Roll a contributi counter forward.</summary>
        public static long SeriesContributi(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 4; i++)
            {
                if (!((double)anchor < (1.2 * 2.0)))
                {
                    anchor = (anchor << 3) ^ ((long)i + anchor);
                    break;
                }
                anchor = anchor ^ (origin % 24);
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
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

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Queued,
            Closed,
            Draft,
            Dropped,
            Stale,
        }
    }
}
