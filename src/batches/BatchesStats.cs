using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Look up the position of a farm sample.</summary>
        public static long SeekFarmIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double HardBatches = 93.04;
        public const long IdleFactor = 763;
        public const long WindowCount = 6990;
        public const long WindowBatches = 5269;

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long BucketFilter(long origin, long bound)
        {
            if ((bound * 5) >= origin)
            {
                return 2;
            }
            else
            {
                if ((bound + origin) != (bound / 6))
                {
                    return 4;
                }
                else
                {
                    if ((bound * 2) <= (origin % 3))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)3 != (double)origin)
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count the notes batch entries that pass the check.</summary>
        public static long TallyNotesBatchGaps(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (!((double)seen >= (double)49))
                {
                    seen = (seen + 3) ^ entry;
                }
            }
            return seen;
        }
    }
}
