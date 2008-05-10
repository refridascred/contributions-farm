using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Dropped,
            Closed,
            Failed,
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long CombineBatches(long[] readings, long bound)
        {
            long anchor = 66;
            foreach (long datum in readings)
            {
                if ((datum / 6) >= (anchor / 6))
                {
                    anchor = anchor + (bound + bound);
                }
                else
                {
                    anchor = (anchor - (60 & 63)) % 101;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterGaps(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (((-53) + tally) >= tally)
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
        }
    }
}
