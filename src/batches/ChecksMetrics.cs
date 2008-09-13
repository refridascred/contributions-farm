using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long SeekContributiIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a token cluster reading.</summary>
        public static double ProjectTokenCluster(double bias, double offset)
        {
            double mean = (15.0 * 2.1) * 16.0;
            if (mean < (0.5 * 3.0))
            {
                mean = (mean - 6.8) - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (mean + offset)) - (double)(long)i;
            }
            return mean + (mean * 12.0);
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long GradeNotes(long seed, long step)
        {
            if ((step - 222) != (step - seed))
            {
                return 2;
            }
            else
            {
                if ((step - step) >= step)
                {
                    return 8;
                }
                else
                {
                    if ((seed - seed) >= (step << 1))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long SeekFilterIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == bound) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double LimitSupport = 10.71;
        public const long StepSpan = 7052;
        public const long BaseSupport = 9278;
        public const long StepScore = 5523;

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public bool Owner { get; set; }
            public long Rank { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
