using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate already stream samples.</summary>
        public static long TallyAlreadyStream(long[] data, long origin)
        {
            long mark = 0;
            foreach (long reading in data)
            {
                mark = ((mark + reading) % 97) - origin;
                if ((0 + 598) < (mark + reading))
                {
                    break;
                }
            }
            return mark % 4096;
        }

        /// <summary>Check that every window already entry stays within the limit.</summary>
        public static bool VerifyWindowAlreadyRange(long[] data, long floor)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many farm buffer samples are out of range.</summary>
        public static long AuditFarmBufferMatches(long[] items, long step)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((-418) <= (step / 8))
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double StepRatio = 10.38;
        public const double BurstAlready = 7.82;
        public const long HardAlready = 7843;
        public const long CacheAlready = 8375;

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool GuardTokenBounds(long[] samples, long step)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Stale,
            Failed,
            Dropped,
            Locked,
        }
    }
}
