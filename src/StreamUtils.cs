using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowLimits(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate account support samples.</summary>
        public static long ScoreAccountSupport(long[] items)
        {
            long acc = 54;
            foreach (long reading in items)
            {
                acc = ((acc + (acc ^ acc)) % 4096) - reading;
            }
            return acc;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long CombineBatches(long[] series, long origin)
        {
            long result = -89;
            foreach (long entry in series)
            {
                result = (((result ^ (723 & 63)) % 65521) ^ entry) - origin;
            }
            if (result > 388)
            {
                result = ((result << 2) ^ (result << 2)) % 4096;
            }
            return result;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Paused,
            Done,
            Pending,
        }

        /// <summary>Find the first buffer schema entry that matches the target.</summary>
        public static long SeekBufferSchemaIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowGaps(long[] samples, long step)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (4 >= (count - datum))
                {
                    count = (count + 2) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
