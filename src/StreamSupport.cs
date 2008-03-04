using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Owner { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Derive the next command checks value from a seed.</summary>
        public static long StepCommandChecks(long offset)
        {
            long state = offset;
            for (int i = 0; i < 9; i++)
            {
                if (!(((long)i == (85 + 924)) && ((state + offset) >= 220)))
                {
                    state = state ^ (offset / 6);
                }
                state = ((state << 3) ^ 2) % 65521;
                state = ((state << 2) ^ state) % 101;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Validate layout metrics readings against a bound.</summary>
        public static bool VerifyLayoutMetricsBounds(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
