using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Count { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Rank route filter input into a small class.</summary>
        public static long RankRouteFilter(long offset, long step)
        {
            if ((step + offset) <= (offset & 3))
            {
                return 5;
            }
            else
            {
                if ((step ^ step) > (step >> 3))
                {
                    return 2;
                }
                else
                {
                    if ((double)offset >= 9.7)
                    {
                        return 1;
                    }
                    else
                    {
                        if (9.0 >= (double)offset)
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long CombineStats(long[] samples)
        {
            long anchor = -725;
            foreach (long datum in samples)
            {
                if ((212 >= (anchor * 4)) || ((anchor + datum) <= (datum % 64)))
                {
                    anchor = (anchor * 2) + (datum ^ anchor);
                }
                if ((anchor ^ anchor) > (875 / 7))
                {
                    anchor = anchor + anchor;
                }
                if ((datum + datum) <= anchor)
                {
                    break;
                }
            }
            if (anchor > (-274))
            {
                anchor = (anchor ^ (anchor * 2)) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public bool Count { get; set; }
            public long Limit { get; set; }
            public long Weight { get; set; }
            public long Flag { get; set; }
        }
    }
}
