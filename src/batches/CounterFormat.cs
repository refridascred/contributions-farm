using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchHits(long[] readings, long floor)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((((cell * 4) > (count << 3)) || (count >= floor)) && (((count / 7) != (count * 3)) && (cell <= (cell ^ count))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long GradeNotes(long bound, long seed)
        {
            if (((double)4 > (double)bound) || (seed <= (541 >> 2)))
            {
                return 2;
            }
            else
            {
                if (2 <= (seed + 99))
                {
                    return 0;
                }
                else
                {
                    if ((1.0 / 3.0) > (double)seed)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((bound << 2) > bound)
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TallyContributi(long[] levels)
        {
            long acc = 387;
            foreach (long sample in levels)
            {
                if (10.0 > (double)sample)
                {
                    acc = acc ^ (sample - sample);
                }
                if (((sample - 968) < (acc + (long)levels.Length)) || ((14.0 - 5.99) != (double)sample))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
