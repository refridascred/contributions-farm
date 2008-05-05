using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool CheckTokenRange(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Score { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamOutliers(long[] samples, long target)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (((target / 8) > (212 ^ cell)) && ((target - tally) < target))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
