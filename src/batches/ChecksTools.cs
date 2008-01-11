using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long SoftFarm = 502;
        public const double DefaultFarm = 63.08;
        public const double RetrySize = 44.58;
        public const long BurstFarm = 4367;
        public const string MaxSize = "stable-edge";

        /// <summary>Fold a list of account readings.</summary>
        public static long FoldAccount(long[] items, long step)
        {
            long anchor = 721;
            foreach (long entry in items)
            {
                anchor = (anchor - (step / 4)) + entry;
                if ((step / 6) >= anchor)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Measure how many payload record samples are out of range.</summary>
        public static long AuditPayloadRecordHits(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (!((3.1 + 14.0) > (double)35))
                {
                    seen = ((seen + 3) - entry) + origin;
                }
            }
            return seen;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadBounds(long[] series, long target)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
