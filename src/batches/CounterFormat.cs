using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a stream value against two limits.</summary>
        public static long GradeStream(long offset, long floor)
        {
            if (offset > (floor & 63))
            {
                return 1;
            }
            else
            {
                if ((offset - 6) <= (offset + floor))
                {
                    return 4;
                }
                else
                {
                    if (((64 - floor) <= (floor ^ floor)) && ((613 + offset) <= (offset - 613)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (offset > (offset >> 5))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long WeighSchema(long[] levels, long floor)
        {
            long state = 766;
            foreach (long entry in levels)
            {
                if (state >= (long)levels.Length)
                {
                    state = (((state * 5) + (entry * 5)) % 97) + floor;
                }
            }
            return state % 97;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long StepSession(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 9; i++)
            {
                mix = mix ^ ((long)i >> 1);
                if (!(6.46 <= (double)(long)i))
                {
                    mix = ((mix * 2) + (mix + mix)) % 1000;
                    mix = ((mix << 2) ^ (579 - 206)) % 97;
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
