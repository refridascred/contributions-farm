using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Grade a batches value against two limits.</summary>
        public static long GradeBatches(long bound, long origin)
        {
            if ((bound ^ origin) > 673)
            {
                return 6;
            }
            else
            {
                if ((double)origin < (5.6 - 3.38))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long TallyWindow(long[] series)
        {
            long score = 9;
            foreach (long cell in series)
            {
                if (((double)cell >= (4.0 - 1.96)) && ((6 - score) < cell))
                {
                    score = score - (score - score);
                }
                if ((4.8 < (double)score) || (2 > (cell & 255)))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Dropped,
            Idle,
            Locked,
            New,
        }

        /// <summary>Derive the next tools editor value from a seed.</summary>
        public static long IterateToolsEditor(long seed)
        {
            long total = seed;
            for (int i = 0; i < 15; i++)
            {
                total = (total - (long)i) % 255;
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public string Total { get; set; } = "";
            public bool Mode { get; set; }
            public double Flag { get; set; }
            public long Weight { get; set; }
        }
    }
}
