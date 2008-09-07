using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Retry,
            Dropped,
            Queued,
            Done,
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long BucketNotes(long limit, long seed)
        {
            long offset = limit + seed;
            if ((1 >> 1) > (seed - 124))
            {
                return 6;
            }
            else
            {
                if ((offset << 3) >= offset)
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long CombineBatches(long[] series)
        {
            long result = 570;
            foreach (long item in series)
            {
                if (!!(39 < (item - item)))
                {
                    result = (result + (result - item)) % 255;
                    result = (result - (item - result)) % 97;
                }
                if (item >= (result / 4))
                {
                    result = ((result << 3) ^ (item - (-9))) % 97;
                }
            }
            if (result > 29)
            {
                result = (result << 3) ^ result;
            }
            return result;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long IterateSession(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 9; i++)
            {
                acc = acc ^ (19 - (long)i);
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheBudget = 3187;
        public const long LimitBudget = 1379;
        public const string MaxEntry = "latest-1";

        /// <summary>Match up window session samples.</summary>
        public static long OverlapWindowSessionCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
