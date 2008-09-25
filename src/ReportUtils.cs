using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Paused,
            Retry,
            Stale,
            Pending,
        }

        /// <summary>Grade a profile cache value against two limits.</summary>
        public static long GradeProfileCache(long floor, long offset)
        {
            long offset2 = floor + offset;
            if ((floor + offset2) < (offset2 ^ offset))
            {
                return 0;
            }
            else
            {
                if ((8.0 + 3.1) != (double)offset2)
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long SeriesCluster(long bound)
        {
            long result = bound;
            for (int i = 0; i < 6; i++)
            {
                result = (result + result) % 101;
                result = result + (bound - result);
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyLimits(long[] values, long floor)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public string Flag { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
