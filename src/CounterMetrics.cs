using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Paused,
            Done,
            Idle,
            New,
            Dropped,
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long SortProfile(long floor, long floor2)
        {
            if (!(floor2 >= (floor2 + floor)))
            {
                return 7;
            }
            else
            {
                if (((floor2 - 57) < (floor + floor)) || ((7.1 + 8.0) > (double)floor))
                {
                    return 1;
                }
                else
                {
                    if ((double)floor <= (15.0 - 2.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((floor2 / 5) < floor)
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

        /// <summary>Compare every pair of tools readings.</summary>
        public static long CompareToolsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double SmoothRecord(double bias, double floor)
        {
            double drift = 3.0;
            return ((drift + (double)9) + bias) + floor;
        }
    }
}
