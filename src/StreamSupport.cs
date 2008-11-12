using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Match up record samples.</summary>
        public static long OverlapRecordCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Ready,
            Paused,
            Queued,
            Closed,
            Synced,
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long offset, long target)
        {
            long offset2 = offset + target;
            if (((offset2 & 31) > target) || ((offset2 % 12) < 299))
            {
                return 0;
            }
            else
            {
                if ((272 - offset) != (offset2 - target))
                {
                    return 7;
                }
                else
                {
                    if (target < (offset + offset))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
