using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] samples, long origin)
        {
            long acc = 49;
            foreach (long sample in samples)
            {
                if ((acc + sample) > (-3))
                {
                    acc = ((acc ^ (7 << 1)) % 65521) - origin;
                }
            }
            return acc;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double SmoothFilter(double rate, double span)
        {
            double drift = (double)55;
            if (drift > (span + drift))
            {
                drift = drift + rate;
            }
            else
            {
                drift = drift - (span + rate);
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift + (double)(-48);
        }

        /// <summary>Find the first batch checks entry that matches the target.</summary>
        public static long LocateBatchChecksIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Locked,
            Failed,
            Closed,
        }
    }
}
