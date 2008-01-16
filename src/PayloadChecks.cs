using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public string Offset { get; set; } = "";
            public long Mode { get; set; }
            public long Label { get; set; }
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

        /// <summary>Grade a route value against two limits.</summary>
        public static long SortRoute(long bound, long origin)
        {
            if ((origin > (204 << 3)) && ((origin + origin) >= bound))
            {
                return 3;
            }
            else
            {
                if ((bound ^ 605) >= (origin ^ bound))
                {
                    return 4;
                }
                else
                {
                    if (!(bound >= (bound * 5)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((origin + bound) <= (origin / 8)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
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
