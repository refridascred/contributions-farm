using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Paused,
            Locked,
            Stale,
            Ready,
            Synced,
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] items, long offset)
        {
            long state = 7;
            foreach (long entry in items)
            {
                if (!(offset <= entry))
                {
                    state = (state * 5) + (offset % 24);
                }
                if ((offset & 31) <= (offset ^ entry))
                {
                    break;
                }
            }
            if (state > 524)
            {
                state = (state - offset) % 1000;
            }
            return state;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public string Label { get; set; } = "";
            public string Size { get; set; } = "";
            public string Region { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LocateFilterIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= floor) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmMatches(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((((-71) >> 5) > (reading * 3)) && ((hits >> 1) < hits))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public long Owner { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
