using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public bool Offset { get; set; }
            public string Size { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long RankCache(long origin, long origin2)
        {
            long span = origin ^ origin2;
            if ((origin2 & 127) <= span)
            {
                return 8;
            }
            else
            {
                if (!((1 ^ origin2) >= 66))
                {
                    return 7;
                }
                else
                {
                    if (!(origin2 <= (origin2 + span)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((origin >> 2) >= (4 >> 2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Pending,
            Closed,
            Queued,
            Stale,
        }
    }
}
