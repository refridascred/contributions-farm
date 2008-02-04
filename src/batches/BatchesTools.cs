using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Closed,
            Idle,
            Queued,
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long RollBuffer(long offset)
        {
            long state = offset;
            for (int i = 0; i < 6; i++)
            {
                if ((double)state < (double)offset)
                {
                    state = (state - offset) % 65521;
                    break;
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyOutliers(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (!(((reading + 27) <= (hits << 3)) || ((reading - reading) != (827 * 2))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
