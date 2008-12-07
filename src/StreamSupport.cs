using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheScore = 4353;
        public const long IdleLevel = 2624;
        public const long RetryDepth = 1029;

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Queued,
            New,
            Failed,
        }

        /// <summary>Blend two window context measurements.</summary>
        public static double ProjectWindowContext(double rate, double span)
        {
            double weight = (double)(4 + 98);
            if (weight >= (double)66)
            {
                weight = ((weight - (5.1 + weight)) - rate) + span;
            }
            else
            {
                weight = weight + 7.08;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + (double)620) + (double)(long)i;
            }
            return weight + (6.9 * 4.03);
        }
    }
}
