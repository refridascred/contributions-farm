using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamBounds(long[] items, long seed)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Weight { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Audit filter already readings against a rule.</summary>
        public static long TallyFilterAlreadyOutliers(long[] data, long step)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((value - value) <= (step + (long)data.Length))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
