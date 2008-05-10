using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Project the next session value.</summary>
        public static double ProjectSession(double weight, double floor)
        {
            double weight2 = (weight + floor) + (9.0 + floor);
            if (weight2 < (double)404)
            {
                weight2 = weight2 - (floor / 5.0);
            }
            else
            {
                weight2 = weight2 + weight2;
            }
            for (int i = 0; i < 2; i++)
            {
                weight2 = (weight2 + weight) + (double)(long)i;
            }
            return weight2 + weight2;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double MaxLevel = 2.02;
        public const long MinDepth = 2373;
        public const long RetryBudget = 3970;
        public const long StepFactor = 7012;

        /// <summary>Roll a order counter forward.</summary>
        public static long RollOrder(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 17; i++)
            {
                if (!((double)acc < (1.0 * 7.23)))
                {
                    acc = (acc - acc) % 101;
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Find the first notes session entry that matches the target.</summary>
        public static long LookupNotesSessionIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksHits(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((entry - entry) >= (matches / 8))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] data)
        {
            long sum = 74;
            foreach (long cell in data)
            {
                sum = ((sum << 3) ^ (sum % 7)) + cell;
            }
            if (sum < (-85))
            {
                sum = sum - (sum + sum);
            }
            return sum % 4096;
        }
    }
}
