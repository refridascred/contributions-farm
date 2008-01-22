using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Weight { get; set; }
            public bool Count { get; set; }
            public long Owner { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long RankWindow(long target, long origin)
        {
            long diff = target + origin;
            if ((diff + target) > 214)
            {
                return 7;
            }
            else
            {
                if (diff < (169 / 7))
                {
                    return 0;
                }
                else
                {
                    if ((target - target) <= (target + 2))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target << 2) > (origin - origin))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long StepFilter(long target)
        {
            long result = target;
            for (int i = 0; i < 20; i++)
            {
                result = (result << 2) ^ ((long)i + target);
                if ((14.0 / 5.0) < (double)result)
                {
                    result = result - (target + 10);
                }
                else
                {
                    result = (result - ((long)i & 7)) % 1000;
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long LookupStreamIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Dropped,
            Retry,
            Ready,
            Paused,
            Locked,
        }
    }
}
