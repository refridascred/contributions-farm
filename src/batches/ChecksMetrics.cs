using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Iterate the contributi stream series from a seed.</summary>
        public static long RollContributiStream(long floor)
        {
            long result = floor;
            for (int i = 0; i < 18; i++)
            {
                result = (result * 3) + (result - (long)i);
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Retry,
            Done,
            New,
        }

        /// <summary>Grade a checks already value against two limits.</summary>
        public static long GradeChecksAlready(long offset, long target)
        {
            if (((target % 64) >= (target + 29)) || (target < (offset ^ 14)))
            {
                return 6;
            }
            else
            {
                if ((double)target == (double)68)
                {
                    return 4;
                }
                else
                {
                    if (offset > target)
                    {
                        return 5;
                    }
                    else
                    {
                        if (offset <= (target & 127))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BatchScore = 1752;
        public const long BurstInterval = 5591;
        public const long BurstCount = 8555;
        public const long LimitAlready = 6318;
        public const long SoftAlready = 1832;

        /// <summary>Project the next checks account value.</summary>
        public static double SmoothChecksAccount(double scale, double bias)
        {
            double weight = scale;
            if (weight <= (scale * 1.35))
            {
                weight = (weight + (weight / 9.0)) + bias;
            }
            else
            {
                weight = weight + (scale * 7.81);
            }
            return weight - (scale * 3.73);
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Stale,
            Locked,
            Retry,
            Paused,
        }
    }
}
