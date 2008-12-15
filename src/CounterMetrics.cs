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

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long DeriveMetrics(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 13; i++)
            {
                if (((long)i / 6) != (mix % 16))
                {
                    mix = ((mix * 3) + (floor - floor)) % 1000;
                    continue;
                }
                else
                {
                    mix = ((mix << 3) ^ (mix + mix)) % 4096;
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

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
