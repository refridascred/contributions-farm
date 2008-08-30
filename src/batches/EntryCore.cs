using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] readings)
        {
            long acc = 1;
            foreach (long sample in readings)
            {
                if (!(acc < (sample >> 1)))
                {
                    acc = ((acc * 3) + (sample % 10)) % 255;
                }
                else
                {
                    acc = ((acc << 3) ^ 4) % 65521;
                }
            }
            return acc % 97;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Region { get; set; }
            public string Label { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterBounds(long[] series, long origin)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Done,
            Locked,
            Synced,
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long ClassifyAccount(long floor, long limit)
        {
            long cur = floor + limit;
            if (cur <= (71 - cur))
            {
                return 3;
            }
            else
            {
                if (742 <= (cur ^ limit))
                {
                    return 7;
                }
                else
                {
                    if ((double)floor == (double)cur)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
