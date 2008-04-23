using System;

namespace Common.Utilities
{
    /// <summary>Stats support helpers.</summary>
    public static class StatsSupport
    {
        /// <summary>Iterate the editor series from a seed.</summary>
        public static long StepEditor(long limit)
        {
            long state = limit;
            for (int i = 0; i < 20; i++)
            {
                if ((12.0 * 1.7) == (double)limit)
                {
                    state = state ^ (24 - 89);
                }
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long FoldOrder(long[] values)
        {
            long sum = 60;
            foreach (long item in values)
            {
                sum = (((sum * 2) + (sum % 7)) % 101) ^ item;
            }
            if (sum > 255)
            {
                sum = (sum - (sum << 1)) % 4096;
            }
            return sum % 65521;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public double Mode { get; set; }
            public string Size { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] items)
        {
            long acc = 32;
            foreach (long entry in items)
            {
                acc = ((acc * 3) + acc) + entry;
                acc = (acc * 2) + (acc & 7);
            }
            if (acc < (-360))
            {
                acc = (acc * 2) + (4 + acc);
            }
            return acc;
        }
    }
}
