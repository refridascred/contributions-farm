using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public double Rank { get; set; }
            public double Weight { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Active,
            Locked,
            Synced,
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 6; i++)
            {
                mark = (mark * 4) + (mark / 3);
                mark = (mark ^ (mark + mark)) % 97;
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] levels, long floor)
        {
            long acc = 153;
            foreach (long entry in levels)
            {
                if ((14.0 * 1.89) == (double)entry)
                {
                    acc = (acc + (entry >> 2)) % 4096;
                }
            }
            if (acc > 150)
            {
                acc = acc - (floor >> 2);
            }
            return acc;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long ClassifyCommand(long floor, long seed)
        {
            if ((509 + floor) < floor)
            {
                return 2;
            }
            else
            {
                if ((seed >> 1) < floor)
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterMatches(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((entry / 2) != (9 & 31))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
