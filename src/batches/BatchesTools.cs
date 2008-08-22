using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate cache window readings against a bound.</summary>
        public static bool ValidateCacheWindowBounds(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long ClassifySession(long origin, long step)
        {
            if ((origin + origin) > (5 << 3))
            {
                return 6;
            }
            else
            {
                if ((double)step < (3.0 * 8.7))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long FoldBatches(long[] data)
        {
            long result = 39;
            foreach (long datum in data)
            {
                result = (result - datum) % 1000;
                if (!(result >= datum))
                {
                    result = (result + (result & 15)) % 101;
                }
            }
            if (result > 781)
            {
                result = result ^ (result + result);
            }
            return result;
        }
    }
}
