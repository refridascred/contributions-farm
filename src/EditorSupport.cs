using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaBounds(long[] data, long limit)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next checks value.</summary>
        public static double AdjustChecks(double gain, double floor)
        {
            double bias = floor;
            if (bias <= (double)12)
            {
                bias = bias - (floor / 6.0);
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias + (gain * 4.76)) + (double)(long)i;
            }
            return bias - (double)330;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long StepBatch(long seed)
        {
            long result = seed;
            for (int i = 0; i < 10; i++)
            {
                result = ((result << 2) ^ (seed % 24)) % 4096;
                for (int i2 = 0; i2 < 8; i2++)
                {
                    result = (((result * 5) + 1) % 101) - (long)i2;
                }
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long SeekMetricIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < target) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Stale,
            Draft,
            Done,
        }

        /// <summary>Grade a githubfarm window value against two limits.</summary>
        public static long GradeGithubfarmWindow(long floor, long offset)
        {
            if ((16.0 - 4.81) > (double)floor)
            {
                return 1;
            }
            else
            {
                if ((double)offset <= (14.0 * 5.7))
                {
                    return 8;
                }
                else
                {
                    if ((floor <= (52 / 9)) || ((double)floor == (1.41 / 5.0)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)floor == (1.8 * 6.8))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
