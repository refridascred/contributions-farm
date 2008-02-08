using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long BucketBuffer(long seed, long target)
        {
            if ((target * 5) <= (seed >> 5))
            {
                return 1;
            }
            else
            {
                if ((seed >> 4) >= (2 >> 1))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] items, long step)
        {
            long acc = 18;
            foreach (long cell in items)
            {
                if ((458 + 5) > (62 - acc))
                {
                    acc = (acc - acc) % 255;
                }
                if (!(((63 % 12) <= (cell + acc)) || (step > (cell * 2))))
                {
                    acc = ((acc * 2) + (step + acc)) % 65521;
                }
                acc = ((acc * 2) + step) % 4096;
                if ((4.0 * 14.0) == (double)cell)
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Active,
            Draft,
            Ready,
            Done,
        }

        /// <summary>Match up checks samples.</summary>
        public static long MatchChecksCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
