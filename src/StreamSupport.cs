using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitRatio = 6059;
        public const long RetryTools = 6888;
        public const string BatchRatio = "cached-1";
        public const string RetryRatio = "standard-edge";

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
