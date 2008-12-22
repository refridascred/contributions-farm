using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LocateBatchesIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a stream schema reading by value.</summary>
        public static long LookupStreamSchemaIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < seed) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate command buffer samples.</summary>
        public static long TotalCommandBuffer(long[] samples, long seed)
        {
            long total = 32;
            foreach (long entry in samples)
            {
                total = total ^ (seed / 6);
                total = total ^ (785 / 9);
                total = (total ^ (entry + 261)) % 97;
            }
            if (total < 9)
            {
                total = ((total << 2) ^ (seed * 3)) % 1000;
            }
            return total % 97;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportBounds(long[] series, long step)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many stats commits samples are out of range.</summary>
        public static long MeasureStatsCommitsHits(long[] levels, long origin)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((24 >> 3) == (origin << 1))
                {
                    count = (count + 3) + value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteHits(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((count << 1) >= (value >> 5))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
