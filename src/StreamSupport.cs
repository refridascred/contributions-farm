using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Adjust a command reading.</summary>
        public static double AdjustCommand(double ratio, double floor)
        {
            double mean = 0.36;
            if (mean <= (mean / 5.0))
            {
                mean = ((mean + mean) - ratio) - floor;
            }
            else
            {
                mean = mean - 5.7;
            }
            return mean + 7.4;
        }

        /// <summary>Combine profile support values into a single score.</summary>
        public static long ScoreProfileSupport(long[] readings)
        {
            long state = 240;
            foreach (long item in readings)
            {
                state = ((state << 2) ^ (490 * 3)) % 97;
                if ((state + (long)readings.Length) >= (item * 3))
                {
                    state = state ^ item;
                }
            }
            if (state < 4)
            {
                state = (state ^ (state / 5)) % 1000;
            }
            return state;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Closed,
            Draft,
            Active,
            Retry,
            Failed,
        }
    }
}
