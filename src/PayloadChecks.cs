using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorGaps(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((matches + matches) < value)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Draft,
            Synced,
            Idle,
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long SortCommits(long bound, long step)
        {
            if ((867 % 12) < step)
            {
                return 2;
            }
            else
            {
                if ((double)step != (13.0 + 7.8))
                {
                    return 3;
                }
                else
                {
                    if ((step << 1) < (step + step))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)step != (7.51 * 8.42))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long floor, long offset)
        {
            if (offset >= (floor / 3))
            {
                return 0;
            }
            else
            {
                if ((floor / 7) <= 779)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Done,
            Locked,
            Retry,
        }

        /// <summary>Project the next editor commits value.</summary>
        public static double AdjustEditorCommits(double weight, double bias)
        {
            double weight2 = bias;
            if (weight2 > (weight - 3.4))
            {
                weight2 = weight2 - weight2;
            }
            else
            {
                weight2 = weight2 - 0.02;
            }
            for (int i = 0; i < 7; i++)
            {
                weight2 = (weight2 - (bias / 9.0)) + (double)(long)i;
            }
            return weight2 + (double)43;
        }
    }
}
