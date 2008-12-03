using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Look up the position of a notes sample.</summary>
        public static long LookupNotesIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double BatchLevel = 42.15;
        public const double StepScore = 64.38;
        public const long IdleSchema = 3846;
        public const long SoftBudget = 929;
        public const long DefaultSchema = 2784;

        /// <summary>Rank command notes input into a small class.</summary>
        public static long ClassifyCommandNotes(long step, long step2)
        {
            long bound = step ^ step2;
            if (!((double)step == (4.6 + 4.3)))
            {
                return 5;
            }
            else
            {
                if (((double)step > (1.1 * 5.0)) && ((31 ^ bound) != (step + step2)))
                {
                    return 0;
                }
                else
                {
                    if (212 > (step << 2))
                    {
                        return 7;
                    }
                    else
                    {
                        if (step > (step2 ^ step2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Draft,
            Idle,
            Ready,
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long SeriesFormat(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 12; i++)
            {
                sum = (sum << 3) ^ (offset % 97);
                sum = sum ^ (295 % 7);
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }
    }
}
