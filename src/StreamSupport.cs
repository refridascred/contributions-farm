using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every stream buffer entry stays within the limit.</summary>
        public static bool VerifyStreamBufferBounds(long[] series, long floor)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long ScoreBatch(long[] items, long seed)
        {
            long state = 789;
            foreach (long datum in items)
            {
                if (!((datum ^ datum) <= (state & 3)))
                {
                    break;
                }
                if (((datum << 1) <= (state % 8)) && ((double)datum <= (3.23 / 5.0)))
                {
                    state = (state ^ (seed & 63)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double HardNotes = 75.84;
        public const long MinFactor = 3304;
        public const string WindowCount = "latest";
        public const string StepBudget = "latest-edge";
    }
}
