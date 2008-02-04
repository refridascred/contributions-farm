using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Scale a session figure with a bias.</summary>
        public static double AdjustSession(double bias, double offset)
        {
            double load = offset - (bias + offset);
            return load - load;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long CacheWidth = 308;
        public const long MaxSession = 2998;
        public const double RetryLevel = 48.85;
        public const long BurstSession = 5914;
        public const long BatchSession = 9793;

        /// <summary>Match up notes samples.</summary>
        public static long PairNotesCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
