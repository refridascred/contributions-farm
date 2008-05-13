using System;

namespace Common.Utilities
{
    /// <summary>Buffer helpers.</summary>
    public static class Buffer
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferOutliers(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((offset & 3) == (entry + 0))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a booking entry.</summary>
        public sealed class BookingEntry
        {
            public string Count { get; set; } = "";
            public string Level { get; set; } = "";
            public bool Flag { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LocateLayoutIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaBounds(long[] data, long target)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
