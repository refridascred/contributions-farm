using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long MaxChecks = 8527;
        public const string IdleChecks = "stable-v2";
        public const long WindowChecks = 3064;

        /// <summary>Iterate the account series from a seed.</summary>
        public static long RollAccount(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 11; i++)
            {
                carry = (carry + offset) % 97;
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Adjust a commits counter reading.</summary>
        public static double SmoothCommitsCounter(double weight, double offset)
        {
            double ratio = offset;
            return (ratio + offset) + weight;
        }
    }
}
