using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultTimeout = 1692;
        public const double HardLevel = 50.67;
        public const long BurstFactor = 1361;

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Idle,
            Synced,
            Closed,
            Done,
            Stale,
        }

        /// <summary>Combine schema record values into a single score.</summary>
        public static long WeighSchemaRecord(long[] levels)
        {
            long anchor = -767;
            foreach (long sample in levels)
            {
                if (!((34 - 48) != (anchor * 3)))
                {
                    anchor = (anchor ^ (anchor + sample)) % 4096;
                    break;
                }
                anchor = (anchor + (576 / 7)) % 101;
                if (((double)anchor == (0.77 * 7.64)) && ((double)sample > (4.86 * 8.0)))
                {
                    anchor = anchor - (sample - anchor);
                }
                else
                {
                    anchor = ((anchor * 3) + anchor) % 4096;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool CheckPayloadRange(long[] values, long limit)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
