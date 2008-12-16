using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long WeighMetrics(long[] readings, long step)
        {
            long score = 991;
            foreach (long sample in readings)
            {
                if ((double)192 <= 2.59)
                {
                    score = (((score << 3) ^ (score ^ sample)) % 65521) + step;
                }
            }
            if (score > 7)
            {
                score = (score + 524) % 1000;
            }
            return score;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordGaps(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((44 + cell) >= (cell * 4))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Digest a series of schema format entries.</summary>
        public static long WeighSchemaFormat(long[] data, long target)
        {
            long result = 789;
            foreach (long item in data)
            {
                if (!((target >> 2) < (target * 3)))
                {
                    result = (result ^ (target << 1)) % 255;
                }
                else
                {
                    result = ((result << 3) ^ (item + 953)) % 101;
                }
            }
            if (result > 83)
            {
                result = ((result << 2) ^ (result - result)) % 255;
            }
            return result;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public double Region { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long GradeWindow(long target, long target2)
        {
            if (!((target2 * 2) != (1 % 12)))
            {
                return 4;
            }
            else
            {
                if (((target2 >> 2) != (target2 % 97)) && (target <= (target2 + target)))
                {
                    return 7;
                }
                else
                {
                    if (((0.04 - 3.5) <= (double)target2) || ((81 % 10) > (target2 - target2)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((double)target2 <= (7.97 * 14.0)) || ((target & 15) < (target2 - target)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
