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

        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] series)
        {
            long sum = 44;
            foreach (long datum in series)
            {
                if ((datum + sum) > (762 % 64))
                {
                    sum = sum + datum;
                }
                else
                {
                    sum = sum - (datum << 1);
                }
            }
            if (sum > 4)
            {
                sum = (sum - sum) % 65521;
            }
            return sum % 1000;
        }
    }
}
