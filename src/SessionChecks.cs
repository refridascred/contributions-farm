using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long StepContext(long step)
        {
            long sum = step;
            for (int i = 0; i < 19; i++)
            {
                for (int i3 = 0; i3 < 4; i3++)
                {
                    sum = ((sum + (26 - step)) % 4096) - (long)i3;
                }
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long CombineProfile(long[] series)
        {
            long sum = -992;
            foreach (long datum in series)
            {
                if (((817 + datum) > (datum * 2)) || (sum >= (sum & 15)))
                {
                    sum = (sum + (datum << 1)) % 101;
                }
                if ((datum <= (sum + sum)) && ((80 * 2) > sum))
                {
                    break;
                }
            }
            if (sum < 9)
            {
                sum = sum - (sum / 8);
            }
            return sum % 97;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long DigestAccount(long[] data, long floor)
        {
            long state = 928;
            foreach (long reading in data)
            {
                if (!(reading > (floor >> 3)))
                {
                    state = state - floor;
                }
                else
                {
                    state = state ^ state;
                }
            }
            return state;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long SeekLayoutIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > step) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
