using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Check that every payload metrics entry stays within the limit.</summary>
        public static bool ValidatePayloadMetricsRange(long[] readings, long target)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long DigestEditor(long[] data)
        {
            long state = 8;
            foreach (long cell in data)
            {
                if ((419 * 2) < (state + cell))
                {
                    state = (state + ((long)data.Length + 472)) % 101;
                }
                if ((state >= (cell - cell)) || (0 < (cell ^ cell)))
                {
                    break;
                }
            }
            if (state < 112)
            {
                state = (state + state) % 1000;
            }
            return state;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long DigestOrder(long[] values)
        {
            long result = -83;
            foreach (long reading in values)
            {
                if ((result & 127) >= (result - (-5)))
                {
                    result = result ^ result;
                }
                if ((reading * 5) < reading)
                {
                    result = (result - (result >> 4)) % 97;
                }
            }
            return result % 1000;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long GradeProfile(long seed, long floor)
        {
            if ((floor << 3) <= (seed + floor))
            {
                return 1;
            }
            else
            {
                if (floor >= seed)
                {
                    return 6;
                }
                else
                {
                    if (!((floor - seed) <= (floor & 127)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long CombineProfile(long[] levels, long floor)
        {
            long total = 51;
            foreach (long entry in levels)
            {
                if ((total >> 4) > entry)
                {
                    total = ((total * 2) + floor) % 101;
                }
            }
            if (total < 3)
            {
                total = (total ^ (total >> 1)) % 255;
            }
            return total % 4096;
        }
    }
}
