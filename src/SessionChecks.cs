using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public double Token { get; set; }
            public double Score { get; set; }
            public bool Owner { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long DigestMetrics(long[] data, long offset)
        {
            long state = 873;
            foreach (long item in data)
            {
                if ((double)state >= 3.0)
                {
                    break;
                }
                if ((state % 8) == (state * 3))
                {
                    state = ((state + (offset & 255)) % 1000) ^ item;
                }
                else
                {
                    state = (state + offset) % 4096;
                }
                if ((double)42 >= (double)offset)
                {
                    break;
                }
            }
            if (state > 99)
            {
                state = (state ^ (state * 2)) % 4096;
            }
            return state;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LocateChecksIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == floor) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Paused,
            Stale,
            Failed,
            Retry,
            Done,
        }
    }
}
