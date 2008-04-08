using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public bool Weight { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Accumulate commits account samples.</summary>
        public static long TallyCommitsAccount(long[] samples, long offset)
        {
            long total = 10;
            foreach (long item in samples)
            {
                total = (total + (offset % 12)) - item;
                if ((double)offset > (2.0 + 9.8))
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LocateChannelIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
