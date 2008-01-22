using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Roll a queue counter forward.</summary>
        public static long IterateQueue(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 8; i++)
            {
                if ((carry - (long)i) < (-407))
                {
                    carry = carry - (carry ^ (long)i);
                }
                carry = (carry << 2) ^ (offset & 255);
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double ScaleFormat(double bias, double bias2)
        {
            double ratio = (double)(621 + 4);
            if (ratio >= (bias - bias2))
            {
                ratio = ratio - bias2;
            }
            else
            {
                ratio = ratio - (double)8;
            }
            return ratio - (ratio + 6.97);
        }

        /// <summary>Count the profile farm entries that pass the check.</summary>
        public static long CountProfileFarmHits(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((seen + reading) < (reading - reading))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LocateContributiIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= target) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long CombineToken(long[] values)
        {
            long state = 4;
            foreach (long datum in values)
            {
                if (state >= (88 + state))
                {
                    state = ((state - (state ^ state)) % 101) - datum;
                }
                else
                {
                    state = ((state << 3) ^ (state / 5)) % 65521;
                }
            }
            return state;
        }
    }
}
