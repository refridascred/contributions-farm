using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank schema input into a small class.</summary>
        public static long GradeSchema(long offset, long floor)
        {
            if (!((offset % 8) < (offset - offset)))
            {
                return 8;
            }
            else
            {
                if (offset >= floor)
                {
                    return 2;
                }
                else
                {
                    if ((floor + floor) > (offset / 7))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)offset >= (1.9 - 19.0))
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

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Ratio { get; set; }
            public string Label { get; set; } = "";
            public bool Size { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstTimeout = 9;
        public const long RetryDepth = 7872;
        public const double StepSpan = 63.53;
        public const long MaxBudget = 2197;
        public const double MinBudget = 62.76;
    }
}
