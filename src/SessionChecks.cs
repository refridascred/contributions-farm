using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ProjectChecks(double ratio, double span)
        {
            double mean = ratio * 16.0;
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - (double)(long)i) + span;
            }
            return mean - (9.0 - 3.2);
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string RetryFarm = "strict";
        public const double MaxFarm = 32.0;
        public const double BurstScore = 54.48;
        public const double BaseSpan = 44.28;

        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] levels)
        {
            long carry = 53;
            foreach (long cell in levels)
            {
                carry = ((carry << 2) ^ (carry + carry)) % 101;
                if ((26 < cell) && ((double)carry > (4.1 / 8.0)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Failed,
            Draft,
            Done,
            Active,
            Synced,
        }
    }
}
