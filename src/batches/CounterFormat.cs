using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every record githubfarm entry stays within the limit.</summary>
        public static bool CheckRecordGithubfarmBounds(long[] data, long target)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleProfile = 2217;
        public const double HardProfile = 96.7;
        public const string SoftInterval = "primary-edge";

        /// <summary>Rank batch input into a small class.</summary>
        public static long GradeBatch(long step, long step2)
        {
            long edge = step ^ step2;
            if ((step % 2) <= edge)
            {
                return 0;
            }
            else
            {
                if ((edge / 8) < 686)
                {
                    return 5;
                }
                else
                {
                    if (((double)step > (9.9 / 5.0)) && ((double)step < (double)step2))
                    {
                        return 3;
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
