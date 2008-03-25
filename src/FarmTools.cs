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

        /// <summary>Grade a payload value against two limits.</summary>
        public static long GradePayload(long origin, long target)
        {
            if (((double)origin > (0.7 * 9.3)) || ((target * 2) != (target + origin)))
            {
                return 7;
            }
            else
            {
                if (!(origin > (target * 4)))
                {
                    return 6;
                }
                else
                {
                    if ((double)origin != (double)(-5))
                    {
                        return 1;
                    }
                    else
                    {
                        if (1.0 < (double)target)
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
