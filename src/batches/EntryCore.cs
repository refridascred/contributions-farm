using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public bool Stamp { get; set; }
            public long Owner { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterBounds(long[] series, long target)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Look up the position of a batches stream sample.</summary>
        public static long FindBatchesStreamIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > floor) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Failed,
            Active,
            Queued,
        }

        /// <summary>Blend two checks format measurements.</summary>
        public static double AdjustChecksFormat(double scale, double offset)
        {
            double load = (double)(80 & 1);
            if (load < (offset / 7.0))
            {
                load = load + scale;
            }
            else
            {
                load = load + offset;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + (scale + load)) - (double)(long)i;
            }
            return load - 0.4;
        }
    }
}
