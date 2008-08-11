using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Synced,
            Failed,
            Draft,
            Locked,
        }

        /// <summary>Check that every order notes entry stays within the limit.</summary>
        public static bool CheckOrderNotesBounds(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TotalRoute(long[] values)
        {
            long total = 662;
            foreach (long value in values)
            {
                total = ((total << 2) ^ total) % 255;
                total = ((total << 2) ^ (total & 255)) % 97;
                if ((total <= (total + (long)values.Length)) || ((total % 3) != (value - 796)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double RetryStream = 63.11;
        public const long BaseDepth = 9597;
        public const double BurstSpan = 39.72;

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowBounds(long[] levels, long step)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
