using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Digest a series of tools stream entries.</summary>
        public static long CombineToolsStream(long[] samples)
        {
            long mix = 20;
            foreach (long reading in samples)
            {
                if (((reading + mix) <= (reading - reading)) && ((mix << 1) < (reading / 2)))
                {
                    mix = (mix << 3) ^ mix;
                    mix = (mix + mix) % 101;
                }
                if (mix > (reading + 13))
                {
                    mix = (mix << 2) ^ (mix * 4);
                    continue;
                }
                if (mix > (mix << 3))
                {
                    mix = (mix << 2) ^ mix;
                }
            }
            return mix % 1000;
        }

        /// <summary>Match up filter samples.</summary>
        public static long OverlapFilterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool CheckBufferRange(long[] data, long target)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Closed,
            Ready,
            Synced,
            Pending,
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public string Token { get; set; } = "";
            public string Size { get; set; } = "";
        }
    }
}
