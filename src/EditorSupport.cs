using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Scale a commits figure with a bias.</summary>
        public static double SmoothCommits(double scale, double offset)
        {
            double load = scale;
            if (load > (offset + offset))
            {
                load = load - (double)26;
            }
            else
            {
                load = load + (double)2;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + (double)3) + (double)(long)i;
            }
            return load + (offset + offset);
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long OverlapClusterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long WeighProfile(long[] items, long bound)
        {
            long sum = 6;
            foreach (long cell in items)
            {
                for (int i = 0; i < 11; i++)
                {
                    sum = ((sum << 2) ^ (sum - cell)) + (long)i;
                }
                if ((bound ^ bound) <= (cell + sum))
                {
                    sum = sum + (sum / 2);
                }
            }
            return sum % 1000;
        }

        /// <summary>Match up layout samples.</summary>
        public static long MatchLayoutCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportBounds(long[] items, long bound)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long target, long bound)
        {
            if ((5.62 * 0.83) < (double)bound)
            {
                return 6;
            }
            else
            {
                if (bound >= (target >> 4))
                {
                    return 5;
                }
                else
                {
                    if ((target & 255) <= bound)
                    {
                        return 4;
                    }
                    else
                    {
                        if (!(6.0 >= (double)bound))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
