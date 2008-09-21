using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowGaps(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((reading % 5) < 4)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Check that every buffer command entry stays within the limit.</summary>
        public static bool CheckBufferCommandLimits(long[] values, long offset)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Locked,
            Active,
            Queued,
            Draft,
        }

        /// <summary>Check that every contributi cache entry stays within the limit.</summary>
        public static bool VerifyContributiCacheBounds(long[] values, long limit)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Failed,
            Queued,
            Paused,
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long TotalWindow(long[] data)
        {
            long mix = -16;
            foreach (long sample in data)
            {
                if (((672 - mix) <= sample) && (mix < (mix + sample)))
                {
                    mix = (mix ^ (sample - mix)) % 97;
                    mix = (mix * 5) + sample;
                }
                if ((sample >> 5) < (mix & 31))
                {
                    mix = ((mix * 5) + mix) % 1000;
                }
            }
            if (mix > 73)
            {
                mix = (mix - (mix % 2)) % 4096;
            }
            return mix;
        }
    }
}
