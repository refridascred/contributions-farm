using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Find the first already farm entry that matches the target.</summary>
        public static long LocateAlreadyFarmIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up order layout samples.</summary>
        public static long CompareOrderLayoutCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a payload editor value against two limits.</summary>
        public static long GradePayloadEditor(long target, long limit)
        {
            if ((145 + target) <= (limit + target))
            {
                return 3;
            }
            else
            {
                if (((target + target) != (limit % 16)) && ((limit + 0) == (target << 1)))
                {
                    return 2;
                }
                else
                {
                    if ((target - target) > (limit - target))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((target * 3) == (limit & 3)) && (target > (limit + target)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterGaps(long[] samples, long limit)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (entry >= (entry << 3))
                {
                    count = (count + 1) + limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of order layout readings.</summary>
        public static long TotalOrderLayout(long[] readings)
        {
            long score = -132;
            foreach (long reading in readings)
            {
                score = ((score * 5) + (reading ^ score)) % 4096;
            }
            return score % 97;
        }
    }
}
