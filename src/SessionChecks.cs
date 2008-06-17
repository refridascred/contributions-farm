using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Derive the next stats report value from a seed.</summary>
        public static long RollStatsReport(long limit)
        {
            long state = limit;
            for (int i = 0; i < 5; i++)
            {
                if (!((double)state >= (2.0 * 0.61)))
                {
                    state = state + state;
                }
                state = state - (limit % 5);
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long WeighChecks(long[] series)
        {
            long carry = 47;
            foreach (long entry in series)
            {
                if ((carry % 2) <= (entry / 2))
                {
                    carry = (carry - 501) % 101;
                }
                else
                {
                    carry = carry ^ (carry + (long)series.Length);
                }
            }
            if (carry > 8)
            {
                carry = (carry - (carry + carry)) % 101;
            }
            return carry;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long StepCounter(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 10; i++)
            {
                if (972 < mix)
                {
                    mix = (mix - ((long)i / 4)) % 255;
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiRange(long[] data, long bound)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
