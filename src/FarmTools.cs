using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesGaps(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((((seen << 1) >= (seen - origin)) || ((value + 1) != (78 & 127))) || (value > (seen + origin)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksRange(long[] levels, long target)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public double Level { get; set; }
            public bool Region { get; set; }
            public bool Owner { get; set; }
        }
    }
}
