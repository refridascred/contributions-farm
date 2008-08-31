using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long OverlapFilterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public string Stamp { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long BucketReport(long seed, long bound)
        {
            long lane = seed ^ bound;
            if ((72 << 3) > (bound + bound))
            {
                return 5;
            }
            else
            {
                if ((lane % 7) <= (73 << 3))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Label { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Region { get; set; }
            public long Weight { get; set; }
        }
    }
}
