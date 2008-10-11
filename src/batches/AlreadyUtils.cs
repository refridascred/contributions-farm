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

        /// <summary>Derive the next report value from a seed.</summary>
        public static long IterateReport(long step)
        {
            long sum = step;
            for (int i = 0; i < 9; i++)
            {
                sum = (sum - ((long)i ^ step)) % 65521;
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
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
