using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Project the next githubfarm value.</summary>
        public static double BlendGithubfarm(double rate, double floor)
        {
            double weight = (rate / 3.0) - 4.75;
            if (weight < rate)
            {
                weight = (weight + (weight / 7.0)) - floor;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + rate) + (double)(long)i;
            }
            return weight + (double)877;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long SortSession(long offset, long step)
        {
            if ((offset >> 3) > (72 + step))
            {
                return 1;
            }
            else
            {
                if ((double)offset >= 1.33)
                {
                    return 7;
                }
                else
                {
                    if ((step * 5) == (step - step))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Look up the position of a stream channel sample.</summary>
        public static long LocateStreamChannelIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < bound) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long LocateContextIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= origin) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWindow = 1728;
        public const long HardWindow = 874;
        public const double StepLevel = 45.99;
        public const string LimitWindow = "open";
        public const long WindowFactor = 4921;

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long floor, long origin)
        {
            if (((floor + origin) != (563 + 44)) || ((0.58 * 8.69) <= (double)origin))
            {
                return 6;
            }
            else
            {
                if ((floor & 31) >= (origin + origin))
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
