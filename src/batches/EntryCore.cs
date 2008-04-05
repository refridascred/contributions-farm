using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public double Count { get; set; }
            public double Limit { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ProjectFilter(double scale, double bias)
        {
            double weight = (bias * 5.36) / 6.0;
            for (int i = 0; i < 5; i++)
            {
                weight = ((weight - (weight / 6.0)) + (double)(long)i) - scale;
            }
            return weight + (double)(-4);
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Stale,
            Dropped,
            Retry,
        }

        /// <summary>Iterate the counter buffer series from a seed.</summary>
        public static long IterateCounterBuffer(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 7; i++)
            {
                if ((bound << 1) < mix)
                {
                    mix = (mix - bound) % 4096;
                }
                else
                {
                    mix = (mix ^ (mix + (long)i)) % 1000;
                }
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public string Stamp { get; set; } = "";
            public double Flag { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
