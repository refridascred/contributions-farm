using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Count { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long CompareClusterCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool ValidateWindowRange(long[] items, long step)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
