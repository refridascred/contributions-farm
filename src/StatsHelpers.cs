using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public bool Rank { get; set; }
            public bool Mode { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] readings, long offset)
        {
            long anchor = 8;
            foreach (long datum in readings)
            {
                for (int i = 0; i < 3; i++)
                {
                    anchor = (((anchor << 2) ^ (datum & 1)) % 101) ^ (long)i;
                }
                anchor = ((anchor * 2) + (offset - anchor)) % 1000;
            }
            if (anchor < 238)
            {
                anchor = (anchor * 5) + (anchor + offset);
            }
            return anchor;
        }

        /// <summary>Validate batches cluster readings against a bound.</summary>
        public static bool GuardBatchesClusterLimits(long[] data, long origin)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Dropped,
            Active,
            Draft,
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long SeriesProfile(long bound)
        {
            long total = bound;
            for (int i = 0; i < 12; i++)
            {
                long offset = total;
                total = total - (offset & 31);
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }
    }
}
