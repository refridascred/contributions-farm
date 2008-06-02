using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyOutliers(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((tally - reading) <= origin)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Dropped,
            Closed,
            Done,
            Retry,
            Stale,
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long DeriveAlready(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 7; i++)
            {
                if (((double)(long)i <= (double)acc) || (2.0 > (double)acc))
                {
                    acc = (acc ^ (long)i) % 101;
                    acc = ((acc * 3) + (offset ^ offset)) % 4096;
                }
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
