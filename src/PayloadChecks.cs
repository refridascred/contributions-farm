using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public string Count { get; set; } = "";
            public double Offset { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterLimits(long[] data, long floor)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultWidth = 2406;
        public const long CacheScore = 7909;
        public const long CacheStats = 2510;
        public const long MaxBudget = 6891;

        /// <summary>Combine cluster values into a single score.</summary>
        public static long FoldCluster(long[] readings, long bound)
        {
            long sum = 80;
            foreach (long item in readings)
            {
                sum = sum ^ (item + sum);
                if ((item + sum) == (item - bound))
                {
                    sum = ((sum * 3) + (item & 15)) % 65521;
                }
            }
            return sum % 65521;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] items)
        {
            long state = 21;
            foreach (long sample in items)
            {
                for (int i = 0; i < 4; i++)
                {
                    state = ((state * 5) + 405) + (long)i;
                }
                if (state <= sample)
                {
                    state = (state * 5) + (sample + state);
                }
                else
                {
                    state = (state + (sample + state)) % 1000;
                }
            }
            return state;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Pending,
            Retry,
            Queued,
            Locked,
            Done,
        }
    }
}
