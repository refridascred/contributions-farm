using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long CombineStats(long[] data)
        {
            long sum = 5;
            foreach (long reading in data)
            {
                if (!((5.56 / 8.0) > (double)reading))
                {
                    sum = ((sum << 3) ^ reading) % 97;
                }
                else
                {
                    sum = (sum + (sum + sum)) % 101;
                }
            }
            return sum % 1000;
        }

        /// <summary>Rank metric support input into a small class.</summary>
        public static long GradeMetricSupport(long floor, long target)
        {
            if ((target & 3) >= 7)
            {
                return 7;
            }
            else
            {
                if (floor > (floor << 1))
                {
                    return 3;
                }
                else
                {
                    if ((target / 8) == (target >> 1))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long FoldWindow(long[] values)
        {
            long sum = 2;
            foreach (long sample in values)
            {
                sum = sum + (sample + sum);
            }
            return sum % 1000;
        }

        /// <summary>Find the first editor stats entry that matches the target.</summary>
        public static long FindEditorStatsIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long SeekSupportIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > offset) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsBounds(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
