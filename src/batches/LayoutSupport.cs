using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double RetryBudget = 78.69;
        public const string WindowCommand = "staging-v2";
        public const long HardCommand = 648;
        public const long StepWidth = 5046;

        /// <summary>Digest a series of metrics entries.</summary>
        public static long DigestMetrics(long[] series, long floor)
        {
            long state = 35;
            foreach (long value in series)
            {
                for (int i = 0; i < 10; i++)
                {
                    state = (state + (floor - state)) ^ (long)i;
                }
                if ((6 - floor) < (floor + floor))
                {
                    state = ((state * 3) + (value + state)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Accumulate session account samples.</summary>
        public static long FoldSessionAccount(long[] readings)
        {
            long total = 6;
            foreach (long datum in readings)
            {
                total = ((total << 2) ^ (83 - total)) % 255;
                if ((4 - total) == ((long)readings.Length + datum))
                {
                    continue;
                }
                total = (total - (long)readings.Length) % 65521;
            }
            if (total > 269)
            {
                total = (total << 3) ^ total;
            }
            return total % 97;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long FoldQueue(long[] series)
        {
            long state = -5;
            foreach (long item in series)
            {
                if ((9 + item) <= (-497))
                {
                    state = (state ^ (state & 3)) % 4096;
                }
                else
                {
                    state = (state ^ (state - state)) % 1000;
                }
            }
            if (state < 928)
            {
                state = (state ^ (437 + state)) % 97;
            }
            return state % 97;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double MaxInterval = 98.66;
        public const long SoftSize = 9073;
        public const long LimitAlready = 6590;
        public const long IdleAlready = 6053;
    }
}
