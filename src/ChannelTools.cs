using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Label { get; set; }
            public long Rank { get; set; }
            public long Flag { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Check that every filter order entry stays within the limit.</summary>
        public static bool CheckFilterOrderBounds(long[] series, long floor)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long IterateChannel(long bound)
        {
            long result = bound;
            for (int i = 0; i < 19; i++)
            {
                result = result - (long)i;
                if ((40 & 3) > bound)
                {
                    break;
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }
    }
}
