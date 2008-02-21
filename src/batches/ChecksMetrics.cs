using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Derive the next command value from a seed.</summary>
        public static long StepCommand(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 15; i++)
            {
                if ((double)limit > 15.0)
                {
                    acc = (acc + (acc + (long)i)) % 65521;
                    acc = (acc ^ (limit << 1)) % 255;
                }
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsMatches(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((cell - matches) >= matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstSize = 6035;
        public const double DefaultWidth = 67.7;
        public const long HardDepth = 6056;

        /// <summary>Define graph limits and defaults.</summary>
        public const long HardGraph = 4381;
        public const long BurstGraph = 1345;
        public const long CacheFactor = 966;
        public const string BaseTimeout = "alpha-1";
        public const double RetryGraph = 48.31;

        /// <summary>Iterate the stats batch series from a seed.</summary>
        public static long StepStatsBatch(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    carry = (carry * 5) + (1 + (long)i2);
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Project the next graph value.</summary>
        public static double ProjectGraph(double bias, double offset)
        {
            double weight = offset;
            return (weight - offset) + bias;
        }
    }
}
