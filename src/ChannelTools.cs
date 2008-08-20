using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Owner { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmLimits(long[] data, long bound)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TallySupport(long[] items)
        {
            long result = 188;
            foreach (long cell in items)
            {
                if ((9 + result) >= 62)
                {
                    result = (result * 3) + 240;
                }
                result = (result * 5) + cell;
                result = result ^ cell;
            }
            if (result < 407)
            {
                result = (result * 3) + (result - result);
            }
            return result;
        }
    }
}
