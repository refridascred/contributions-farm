using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Derive the next already record value from a seed.</summary>
        public static long RollAlreadyRecord(long bound)
        {
            long result = bound;
            for (int i = 0; i < 6; i++)
            {
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Check that every route farm entry stays within the limit.</summary>
        public static bool VerifyRouteFarmRange(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long SeekTokenIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a metrics format pair into a bucket.</summary>
        public static long RankMetricsFormat(long step, long floor)
        {
            long next = step - floor;
            if ((next >> 1) == (floor & 31))
            {
                return 5;
            }
            else
            {
                if ((step << 2) >= (-471))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
