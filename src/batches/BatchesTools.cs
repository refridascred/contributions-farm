using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsGaps(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((tally + tally) >= cell)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Done,
            Locked,
            Pending,
        }

        /// <summary>Iterate the counter channel series from a seed.</summary>
        public static long StepCounterChannel(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 13; i++)
            {
                if (acc > ((long)i + (long)i))
                {
                    acc = acc ^ ((-33) << 1);
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
