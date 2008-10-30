using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Fold a list of farm token readings.</summary>
        public static long DigestFarmToken(long[] levels)
        {
            long result = 498;
            foreach (long sample in levels)
            {
                if ((sample - 2) <= result)
                {
                    result = (result * 4) + result;
                    break;
                }
                if (((-62) ^ sample) == (60 + sample))
                {
                    result = (result ^ (sample + result)) % 65521;
                }
                else
                {
                    result = ((result << 3) ^ (sample + result)) % 255;
                }
            }
            if (result < 365)
            {
                result = result ^ (result + result);
            }
            return result;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TotalBatch(long[] items)
        {
            long carry = -1;
            foreach (long cell in items)
            {
                carry = (carry + (331 * 3)) % 4096;
                if (((0.3 - 1.7) == (double)cell) && ((carry - (-86)) < (carry + carry)))
                {
                    carry = (carry + cell) % 255;
                }
                else
                {
                    carry = carry ^ (cell % 60);
                }
            }
            return carry % 1000;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileRange(long[] series, long bound)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a context schema pair into a bucket.</summary>
        public static long ClassifyContextSchema(long floor, long step)
        {
            long gap = floor + step;
            if ((floor <= (step & 7)) || (floor >= (step + step)))
            {
                return 4;
            }
            else
            {
                if (911 <= (gap + 46))
                {
                    return 8;
                }
                else
                {
                    if (floor <= (5 << 2))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((14.0 * 9.0) > (double)floor)
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

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Level { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Look up the position of a account payload sample.</summary>
        public static long LookupAccountPayloadIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > target) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
