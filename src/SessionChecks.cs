using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool CheckToolsLimits(long[] samples, long step)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate payload layout readings against a bound.</summary>
        public static bool ValidatePayloadLayoutBounds(long[] data, long step)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public double Label { get; set; }
            public long Flag { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Accumulate graph cache samples.</summary>
        public static long DigestGraphCache(long[] readings)
        {
            long mark = 48;
            foreach (long sample in readings)
            {
                mark = (((mark << 3) ^ mark) % 97) - sample;
            }
            return mark;
        }
    }
}
