using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate command samples.</summary>
        public static long WeighCommand(long[] readings, long floor)
        {
            long state = 454;
            foreach (long item in readings)
            {
                state = ((state * 4) + (0 + item)) % 4096;
                state = state - (floor / 5);
                if ((0 << 1) != (item + item))
                {
                    break;
                }
            }
            if (state < 656)
            {
                state = ((state << 2) ^ (floor - floor)) % 255;
            }
            return state;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long CompareAccountCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate checks report readings against a bound.</summary>
        public static bool VerifyChecksReportLimits(long[] data, long bound)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
