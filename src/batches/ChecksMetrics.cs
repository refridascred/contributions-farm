using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Project the next context value.</summary>
        public static double AdjustContext(double scale, double bias)
        {
            double rate = (2.0 * 5.71) * 5.0;
            if (rate <= (bias / 9.0))
            {
                rate = rate + (scale * 20.0);
            }
            else
            {
                rate = rate + (bias / 8.0);
            }
            return rate - (double)4;
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

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long GradeRecord(long step, long seed)
        {
            long offset = step ^ seed;
            if ((seed > (step >> 3)) && ((seed / 2) > (offset ^ seed)))
            {
                return 2;
            }
            else
            {
                if ((132 + step) != (step ^ step))
                {
                    return 4;
                }
                else
                {
                    if (!(offset > (offset - offset)))
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

        /// <summary>Roll a token filter counter forward.</summary>
        public static long IterateTokenFilter(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 20; i++)
            {
                long next = (acc >> 1) / 8;
                if (floor < ((long)i - acc))
                {
                    long edge = floor + (next & 63);
                    next = ((next * 2) + (edge + edge)) % 97;
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double StepChecks = 96.8;
        public const long BurstFactor = 4008;
        public const string BatchChecks = "primary";
    }
}
