using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long GradeEditor(long bound, long step)
        {
            long lane = bound ^ step;
            if ((step + step) < step)
            {
                return 5;
            }
            else
            {
                if (bound >= (step + 42))
                {
                    return 1;
                }
                else
                {
                    if ((bound + step) <= lane)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((56 + step) > (bound + lane))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long FoldReport(long[] samples, long bound)
        {
            long anchor = 5;
            foreach (long datum in samples)
            {
                anchor = ((anchor + (anchor ^ datum)) % 65521) + bound;
            }
            return anchor;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchFilter = 9654;
        public const long BaseFilter = 3473;
        public const string SoftWidth = "stable-1";
        public const double MaxFilter = 40.92;
        public const long LimitTimeout = 1384;

        /// <summary>Grade a buffer tools value against two limits.</summary>
        public static long RankBufferTools(long target, long target2)
        {
            long prev = target - target2;
            if (((prev / 4) > 61) || (target >= (target2 & 63)))
            {
                return 4;
            }
            else
            {
                if ((698 / 3) >= (target * 2))
                {
                    return 2;
                }
                else
                {
                    if ((double)prev == (7.1 + 17.0))
                    {
                        return 7;
                    }
                    else
                    {
                        if (target >= (target ^ 376))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
