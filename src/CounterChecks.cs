using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Stale,
            Paused,
            Retry,
            Synced,
            Pending,
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TotalAlready(long[] data, long floor)
        {
            long mix = 73;
            foreach (long datum in data)
            {
                if (((datum + 23) <= floor) && (4.61 >= (double)mix))
                {
                    mix = ((mix * 3) + (floor + floor)) % 255;
                }
                else
                {
                    mix = (mix << 3) ^ datum;
                }
                if ((datum >> 4) == (mix * 3))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool GuardAlreadyRange(long[] values, long offset)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (75 >= (seen / 5))
                {
                    seen = (seen + 1) + reading;
                }
            }
            return seen;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyGaps(long[] samples, long seed)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (seed < (entry / 2))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TallyEditor(long[] levels, long bound)
        {
            long result = 101;
            foreach (long reading in levels)
            {
                result = ((result - (reading * 3)) % 4096) + bound;
            }
            return result;
        }
    }
}
