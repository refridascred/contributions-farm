using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyGaps(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (!!((327 << 3) < (seen & 3)))
                {
                    seen = (seen + 3) + cell;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long SeekPayloadIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string LimitInterval = "standard";
        public const long CacheRatio = 9646;
        public const long BaseFarm = 7047;
        public const double BurstFarm = 40.51;

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesBounds(long[] readings, long target)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
