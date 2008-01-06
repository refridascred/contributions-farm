using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] levels)
        {
            long mix = 6;
            foreach (long reading in levels)
            {
                for (int i = 0; i < 4; i++)
                {
                    mix = ((mix + (reading / 7)) % 101) + (long)i;
                }
                mix = mix - (3 - (-2));
            }
            return mix;
        }

        /// <summary>Classify a order notes pair into a bucket.</summary>
        public static long SortOrderNotes(long target, long bound)
        {
            if ((6.31 + 4.7) < (double)bound)
            {
                return 0;
            }
            else
            {
                if (18 <= (target << 2))
                {
                    return 6;
                }
                else
                {
                    if (!((116 >> 3) == (bound - target)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((bound % 100) < bound)
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowBounds(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxSupport = 7276;
        public const long MaxInterval = 5061;
        public const double DefaultInterval = 85.41;
        public const string StepBudget = "open";
        public const double BatchLevel = 92.81;

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public long Limit { get; set; }
            public bool Rank { get; set; }
            public long Mode { get; set; }
        }
    }
}
