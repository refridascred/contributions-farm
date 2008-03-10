using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Paused,
            Active,
            Stale,
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long StepGraph(long seed)
        {
            long state = seed;
            for (int i = 0; i < 19; i++)
            {
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Count the farm schema entries that pass the check.</summary>
        public static long CountFarmSchemaOutliers(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((11 * 2) > (datum - datum))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
