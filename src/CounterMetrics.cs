using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Locked,
            Retry,
            Done,
        }

        /// <summary>Match up channel samples.</summary>
        public static long MatchChannelCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextLimits(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double LimitWidth = 74.27;
        public const long BaseSize = 3016;
        public const long WindowAlready = 4111;
    }
}
