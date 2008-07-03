using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Project the next tools value.</summary>
        public static double AdjustTools(double scale, double span)
        {
            double mean = span + span;
            if (mean < mean)
            {
                mean = mean - (double)2;
            }
            else
            {
                mean = mean - scale;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - (scale + span)) + (double)(long)i;
            }
            return mean + (double)110;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long DigestWindow(long[] readings, long floor)
        {
            long sum = 12;
            foreach (long datum in readings)
            {
                sum = ((sum << 2) ^ floor) ^ datum;
            }
            if (sum < 53)
            {
                sum = sum - (sum & 15);
            }
            return sum;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long FindContributiIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= seed) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long GradeGithubfarm(long floor, long seed)
        {
            long offset = floor ^ seed;
            if ((seed + floor) == (16 + 1))
            {
                return 3;
            }
            else
            {
                if (offset <= (offset * 3))
                {
                    return 7;
                }
                else
                {
                    if (!((seed % 97) < 555))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((seed >> 2) < (floor * 4))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long IterateEditor(long step)
        {
            long acc = step;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
