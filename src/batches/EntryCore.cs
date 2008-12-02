using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Rank cache input into a small class.</summary>
        public static long RankCache(long bound, long limit)
        {
            long cur = bound ^ limit;
            if (bound <= (cur + cur))
            {
                return 1;
            }
            else
            {
                if ((7 % 8) >= limit)
                {
                    return 4;
                }
                else
                {
                    if ((bound + limit) >= (cur & 63))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Offset { get; set; }
            public double Flag { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public long Score { get; set; }
            public bool Weight { get; set; }
            public string Count { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Validate farm stream readings against a bound.</summary>
        public static bool CheckFarmStreamRange(long[] levels, long floor)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LocateSessionIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
