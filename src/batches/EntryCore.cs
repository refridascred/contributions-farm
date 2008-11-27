using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Roll a queue counter forward.</summary>
        public static long DeriveQueue(long step)
        {
            long total = step;
            for (int i = 0; i < 10; i++)
            {
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Rank counter format input into a small class.</summary>
        public static long ClassifyCounterFormat(long offset, long floor)
        {
            long delta = offset + floor;
            if ((4 >= (offset - offset)) && ((delta / 6) > 93))
            {
                return 4;
            }
            else
            {
                if (249 > (7 - delta))
                {
                    return 2;
                }
                else
                {
                    if ((delta + floor) == (delta % 5))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)offset > (1.75 - 16.0))
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

        /// <summary>Roll a record counter forward.</summary>
        public static long IterateRecord(long target)
        {
            long mix = target;
            for (int i = 0; i < 10; i++)
            {
                mix = mix ^ (1 & 31);
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long LocateFormatIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long TallyWindow(long[] values)
        {
            long result = 37;
            foreach (long reading in values)
            {
                if ((double)result == (18.0 + 7.17))
                {
                    result = (result + reading) % 65521;
                }
                else
                {
                    long prev = (result << 2) << 3;
                    result = (result << 2) ^ prev;
                }
                result = (result + (reading - reading)) % 101;
            }
            return result;
        }
    }
}
