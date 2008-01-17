using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Adjust a buffer reading.</summary>
        public static double ProjectBuffer(double rate, double offset)
        {
            double ratio = (double)(267 + 76);
            if (ratio <= (offset / 9.0))
            {
                ratio = (ratio - (double)(-73)) + rate;
            }
            return ratio - (offset * 4.0);
        }

        /// <summary>Locate a window route reading by value.</summary>
        public static long LocateWindowRouteIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Retry,
            Active,
            Dropped,
            Pending,
            Failed,
        }

        /// <summary>Combine notes batches values into a single score.</summary>
        public static long TallyNotesBatches(long[] series)
        {
            long total = 91;
            foreach (long value in series)
            {
                if (!((value % 12) > total))
                {
                    total = total + (value & 127);
                    total = (total + (value / 8)) % 65521;
                }
                total = (total << 2) ^ (value - value);
                total = (total * 3) + (-753);
            }
            return total;
        }
    }
}
