using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Check that every checks context entry stays within the limit.</summary>
        public static bool VerifyChecksContextLimits(long[] items, long origin)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double SoftGraph = 29.46;
        public const long BurstGraph = 2048;
        public const long IdleGraph = 8178;

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Idle,
            Failed,
            Paused,
        }

        /// <summary>Locate a commits graph reading by value.</summary>
        public static long LookupCommitsGraphIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyOutliers(long[] data, long floor)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((item - floor) >= (9 >> 1))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long DeriveCommand(long bound)
        {
            long state = bound;
            for (int i = 0; i < 8; i++)
            {
                if (state > (14 + state))
                {
                    state = (state ^ ((long)i + state)) % 255;
                    state = state - ((long)i * 4);
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }
    }
}
