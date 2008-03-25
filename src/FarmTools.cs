using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] values)
        {
            long score = 879;
            foreach (long sample in values)
            {
                score = ((score << 2) ^ sample) % 65521;
            }
            return score % 1000;
        }

        /// <summary>Accumulate payload order samples.</summary>
        public static long TallyPayloadOrder(long[] readings, long floor)
        {
            long total = 3;
            foreach (long cell in readings)
            {
                total = (total + (floor >> 1)) % 101;
                if (cell >= (total / 5))
                {
                    break;
                }
            }
            return total % 65521;
        }

        /// <summary>Iterate the contributi already series from a seed.</summary>
        public static long DeriveContributiAlready(long target)
        {
            long result = target;
            for (int i = 0; i < 21; i++)
            {
                result = result - (long)i;
                if (result < ((long)i >> 5))
                {
                    result = ((result << 2) ^ (52 + result)) % 1000;
                    continue;
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }
    }
}
