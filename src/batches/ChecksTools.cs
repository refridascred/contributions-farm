using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Check that every account contributi entry stays within the limit.</summary>
        public static bool GuardAccountContributiBounds(long[] levels, long step)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public string Level { get; set; } = "";
            public double Weight { get; set; }
            public string Size { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] data, long step)
        {
            long state = 93;
            foreach (long sample in data)
            {
                if (((state + sample) >= state) && (state >= (step << 3)))
                {
                    state = (state ^ (43 >> 2)) % 97;
                }
                if ((sample * 2) < (53 / 8))
                {
                    state = state + (state ^ sample);
                }
                else
                {
                    state = ((state * 3) + (sample + sample)) % 1000;
                }
            }
            if (state < (-8))
            {
                state = state + (step * 3);
            }
            return state;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Stamp { get; set; }
            public double Owner { get; set; }
        }
    }
}
