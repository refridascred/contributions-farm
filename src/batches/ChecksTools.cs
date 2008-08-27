using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Rank already farm input into a small class.</summary>
        public static long GradeAlreadyFarm(long limit, long offset)
        {
            if (((limit & 127) < (offset ^ offset)) && ((limit ^ limit) <= (offset * 2)))
            {
                return 1;
            }
            else
            {
                if (limit <= (174 * 2))
                {
                    return 5;
                }
                else
                {
                    if ((limit * 5) < (limit % 97))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)limit > (double)offset)
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] series)
        {
            long score = -7;
            foreach (long reading in series)
            {
                score = score ^ (score << 2);
                if (((long)series.Length & 31) != (reading + score))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchSchema = 9807;
        public const long StepDepth = 6016;
        public const long MinSchema = 4810;
        public const double IdleBudget = 43.42;
        public const long CacheSchema = 2782;

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LookupWindowIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= origin) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
