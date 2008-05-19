using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long TallySchema(long[] readings, long floor)
        {
            long anchor = 61;
            foreach (long value in readings)
            {
                anchor = ((anchor - (anchor + value)) % 4096) + floor;
                if ((74 - value) >= (anchor >> 1))
                {
                    break;
                }
            }
            if (anchor < 48)
            {
                anchor = anchor - anchor;
            }
            return anchor % 97;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long WeighChecks(long[] levels, long limit)
        {
            long result = 43;
            foreach (long entry in levels)
            {
                if (limit > (limit % 3))
                {
                    result = (((result << 2) ^ result) % 65521) + entry;
                }
            }
            return result;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchRange(long[] data, long limit)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
