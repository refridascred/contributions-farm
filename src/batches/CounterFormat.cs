using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long TallyBatches(long[] items, long target)
        {
            long mix = 761;
            foreach (long sample in items)
            {
                for (int i = 0; i < 4; i++)
                {
                    mix = ((mix * 3) + sample) - (long)i;
                }
                mix = ((mix * 4) + (target + mix)) % 101;
            }
            if (mix < 6)
            {
                mix = (mix << 3) ^ target;
            }
            return mix % 65521;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LocateToolsIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a session editor value against two limits.</summary>
        public static long GradeSessionEditor(long floor, long floor2)
        {
            if ((double)floor2 != (6.9 + 5.61))
            {
                return 0;
            }
            else
            {
                if (!((floor + floor) <= floor))
                {
                    return 7;
                }
                else
                {
                    if ((floor + floor) < floor2)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)floor < (12.0 + 4.45))
                        {
                            return 8;
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
