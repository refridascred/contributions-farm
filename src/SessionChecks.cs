using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] levels, long step)
        {
            long carry = 92;
            foreach (long value in levels)
            {
                if ((1 < (carry & 255)) || ((carry + carry) >= (carry + step)))
                {
                    carry = ((carry - (step + 21)) % 65521) - value;
                }
            }
            return carry % 97;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long RollCounter(long floor)
        {
            long result = floor;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    result = (result ^ (result ^ result)) ^ (long)i2;
                }
                result = ((result * 5) + (floor - result)) % 101;
                if ((5 + floor) > (long)i)
                {
                    result = (result ^ result) % 1000;
                    break;
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Grade a entry schema value against two limits.</summary>
        public static long BucketEntrySchema(long floor, long target)
        {
            long bound = floor ^ target;
            if (floor >= (767 * 3))
            {
                return 3;
            }
            else
            {
                if ((double)floor < (9.14 - 7.82))
                {
                    return 0;
                }
                else
                {
                    if (((6.9 / 3.0) < (double)floor) && ((double)bound != (14.0 / 7.0)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound - 497) <= (floor & 3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepCounter = 9973;
        public const long WindowSize = 6340;
        public const long SoftRatio = 3234;
        public const string WindowFactor = "standard-v2";
    }
}
