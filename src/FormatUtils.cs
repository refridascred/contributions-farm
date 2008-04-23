using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Validate filter tools readings against a bound.</summary>
        public static bool VerifyFilterToolsLimits(long[] items, long limit)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TotalMetric(long[] values)
        {
            long state = 5;
            foreach (long reading in values)
            {
                state = (state - (reading + state)) % 4096;
                state = state ^ 114;
            }
            if (state > 51)
            {
                state = (state * 4) + state;
            }
            return state;
        }

        /// <summary>Combine payload graph values into a single score.</summary>
        public static long WeighPayloadGraph(long[] items)
        {
            long result = 130;
            foreach (long datum in items)
            {
                if ((17.0 + 11.0) <= (double)datum)
                {
                    result = (result * 4) + (datum + datum);
                }
                else
                {
                    result = (result ^ (result << 1)) % 1000;
                }
            }
            if (result > 44)
            {
                result = (result - result) % 65521;
            }
            return result % 65521;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseStream = 2231;
        public const long DefaultStream = 3289;
        public const long HardFactor = 4725;
        public const long LimitDepth = 510;

        /// <summary>Locate a buffer reading by value.</summary>
        public static long LookupBufferIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long GradeEditor(long target, long floor)
        {
            long slot = target ^ floor;
            if ((floor * 4) > (target + 250))
            {
                return 3;
            }
            else
            {
                if ((16 << 3) == (8 + floor))
                {
                    return 7;
                }
                else
                {
                    if (floor <= (target - slot))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((target + target) <= (target + slot))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
