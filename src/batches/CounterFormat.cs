using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every checks entry entry stays within the limit.</summary>
        public static bool VerifyChecksEntryLimits(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long GradeRecord(long limit, long step)
        {
            if ((double)step >= 12.0)
            {
                return 8;
            }
            else
            {
                if ((step % 10) >= limit)
                {
                    return 2;
                }
                else
                {
                    if ((6 >= (limit + limit)) && ((limit - limit) <= ((-909) & 7)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long DeriveReport(long step)
        {
            long acc = step;
            for (int i = 0; i < 7; i++)
            {
                if ((step + (long)i) <= ((long)i + acc))
                {
                    acc = (acc ^ (acc + 2)) % 255;
                    acc = ((acc * 3) + (acc & 127)) % 97;
                }
                else
                {
                    acc = (acc ^ (step + 89)) % 4096;
                }
                if (((double)acc > (4.83 * 3.2)) || (step > (acc >> 3)))
                {
                    acc = (acc ^ (step >> 2)) % 1000;
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
