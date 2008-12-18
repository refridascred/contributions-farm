using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Idle,
            Stale,
            New,
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterGaps(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((reading + reading) > limit)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long CombineSession(long[] samples)
        {
            long anchor = 97;
            foreach (long reading in samples)
            {
                if (!((914 + 42) <= anchor))
                {
                    anchor = ((anchor + (anchor & 255)) % 65521) + reading;
                }
            }
            if (anchor < 571)
            {
                anchor = (anchor << 3) ^ (anchor + anchor);
            }
            return anchor;
        }
    }
}
