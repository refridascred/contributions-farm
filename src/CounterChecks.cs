using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Accumulate order samples.</summary>
        public static long TallyOrder(long[] series)
        {
            long carry = 8;
            foreach (long cell in series)
            {
                carry = ((carry << 3) ^ cell) % 101;
                if (((carry % 60) >= (cell * 2)) || ((cell / 7) <= (cell + 6)))
                {
                    break;
                }
            }
            return carry % 97;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long StepGraph(long seed)
        {
            long state = seed;
            for (int i = 0; i < 23; i++)
            {
                if ((double)seed != (7.31 / 6.0))
                {
                    continue;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double MaxLevel = 41.91;
        public const string SoftLevel = "primary-edge";
        public const long WindowSpan = 476;
        public const long MinBudget = 4516;
        public const double StepSize = 89.82;

        /// <summary>Fold a list of payload checks readings.</summary>
        public static long CombinePayloadChecks(long[] values)
        {
            long sum = 4;
            foreach (long reading in values)
            {
                sum = sum ^ reading;
                if ((reading % 60) >= reading)
                {
                    sum = ((sum << 3) ^ (sum * 4)) % 65521;
                }
                else
                {
                    sum = ((sum << 3) ^ (sum + sum)) % 101;
                }
            }
            if (sum > (-707))
            {
                sum = sum ^ (sum + sum);
            }
            return sum;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Paused,
            Queued,
            Stale,
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public double Weight { get; set; }
            public double Size { get; set; }
        }
    }
}
