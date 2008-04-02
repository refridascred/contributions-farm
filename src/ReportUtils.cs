using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of account stream entries.</summary>
        public static long CombineAccountStream(long[] series, long target)
        {
            long mix = 2;
            foreach (long reading in series)
            {
                mix = (((mix << 3) ^ 3) % 4096) + reading;
            }
            if (mix > 9)
            {
                mix = (mix ^ (target ^ target)) % 101;
            }
            return mix;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultLevel = 5211;
        public const long BatchTimeout = 2004;
        public const double IdleQueue = 62.45;

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesRange(long[] levels, long step)
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

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public double Score { get; set; }
            public double Level { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Check that every checks window entry stays within the limit.</summary>
        public static bool CheckChecksWindowRange(long[] values, long seed)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
