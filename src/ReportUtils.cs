using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long HardFilter = 5516;
        public const double HardBudget = 86.56;
        public const long LimitFilter = 4101;
        public const string DefaultFilter = "strict-1";

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long SortTools(long floor, long origin)
        {
            if (origin <= (origin + origin))
            {
                return 7;
            }
            else
            {
                if (((9.0 * 5.61) <= (double)floor) || ((double)floor != (double)origin))
                {
                    return 4;
                }
                else
                {
                    if (((13.0 * 17.0) <= (double)floor) && ((origin >> 2) > floor))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)floor >= (double)origin)
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
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepNotes = 4253;
        public const double SoftNotes = 67.94;
        public const long StepInterval = 2624;
        public const string BaseScore = "open";

        /// <summary>Look up the position of a editor sample.</summary>
        public static long FindEditorIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a farm payload counter forward.</summary>
        public static long StepFarmPayload(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 18; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
