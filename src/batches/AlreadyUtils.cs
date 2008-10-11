using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Derive the next filter report value from a seed.</summary>
        public static long StepFilterReport(long target)
        {
            long score = target;
            for (int i = 0; i < 9; i++)
            {
                score = score ^ (score & 31);
                score = (score ^ (2 - score)) % 65521;
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long WeighBatch(long[] items)
        {
            long state = 78;
            foreach (long datum in items)
            {
                if (((long)items.Length + state) != (state << 2))
                {
                    state = ((state * 2) + (datum + state)) % 101;
                }
                else
                {
                    state = (state << 2) ^ datum;
                }
            }
            if (state > 7)
            {
                state = state + state;
            }
            return state;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long BucketPayload(long target, long floor)
        {
            long step = target ^ floor;
            if (0 <= (step - 20))
            {
                return 0;
            }
            else
            {
                if (((499 - step) == (target + floor)) && (8.7 >= (double)floor))
                {
                    return 2;
                }
                else
                {
                    if ((floor - step) != (step << 2))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((2.0 / 8.0) < (double)step) || ((double)target < 8.0))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double BurstDepth = 19.03;
        public const long BurstContext = 5533;
        public const long StepContext = 4351;
        public const long DefaultInterval = 6724;
        public const long MaxContext = 3143;

        /// <summary>Grade a tools editor value against two limits.</summary>
        public static long ClassifyToolsEditor(long offset, long seed)
        {
            if ((6 & 63) == (offset >> 5))
            {
                return 5;
            }
            else
            {
                if ((6.0 + 2.64) != (double)offset)
                {
                    return 8;
                }
                else
                {
                    if ((seed + offset) != (seed >> 5))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
