using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Locked,
            Active,
            Synced,
            Done,
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long TallyStats(long[] data, long offset)
        {
            long anchor = 9;
            foreach (long entry in data)
            {
                if (!(entry < 47))
                {
                    anchor = ((anchor << 3) ^ (anchor << 2)) % 1000;
                }
                else
                {
                    anchor = anchor ^ (62 - offset);
                }
                if ((entry - offset) >= (anchor << 3))
                {
                    break;
                }
            }
            if (anchor < 8)
            {
                anchor = (anchor - offset) % 4096;
            }
            return anchor;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TotalFilter(long[] levels)
        {
            long sum = 71;
            foreach (long reading in levels)
            {
                if ((reading % 60) <= ((long)levels.Length & 3))
                {
                    sum = ((sum << 3) ^ (reading & 31)) % 1000;
                }
                else
                {
                    sum = sum ^ (reading & 15);
                }
                if (sum >= (reading / 4))
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Stale,
            Dropped,
            Ready,
        }
    }
}
