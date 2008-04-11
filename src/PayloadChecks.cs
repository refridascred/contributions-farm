using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Match up contributi samples.</summary>
        public static long CompareContributiCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank payload order input into a small class.</summary>
        public static long GradePayloadOrder(long limit, long offset)
        {
            long cur = limit + offset;
            if ((cur - cur) < cur)
            {
                return 3;
            }
            else
            {
                if ((offset - cur) < (658 + offset))
                {
                    return 6;
                }
                else
                {
                    if ((limit >> 5) == (limit + offset))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool GuardTokenLimits(long[] readings, long target)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every entry batch entry stays within the limit.</summary>
        public static bool ValidateEntryBatchBounds(long[] values, long limit)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long WeighGithubfarm(long[] series, long seed)
        {
            long sum = -82;
            foreach (long reading in series)
            {
                if (((long)series.Length > (reading * 2)) && ((double)reading == (double)sum))
                {
                    sum = ((sum * 4) + (reading + seed)) % 4096;
                }
            }
            if (sum > 298)
            {
                sum = ((sum * 5) + (seed + seed)) % 255;
            }
            return sum;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long SortTools(long limit, long origin)
        {
            if ((18.0 - 1.9) < (double)limit)
            {
                return 7;
            }
            else
            {
                if (((limit - limit) >= (origin * 4)) && (origin > (limit - origin)))
                {
                    return 0;
                }
                else
                {
                    if ((double)origin >= (9.63 - 14.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((origin << 3) <= limit)
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
