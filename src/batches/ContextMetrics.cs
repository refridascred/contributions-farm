using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordGaps(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((tally << 2) != (23 / 2))
                {
                    tally = (tally + 3) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long GradeRecord(long offset, long bound)
        {
            long next = offset ^ bound;
            if (!((offset << 2) >= (bound + bound)))
            {
                return 1;
            }
            else
            {
                if ((bound * 5) > (bound % 16))
                {
                    return 2;
                }
                else
                {
                    if ((bound % 64) < 957)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)next > 9.0)
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepSchema = 7625;
        public const long RetryDepth = 4089;
        public const double BatchSchema = 85.17;
        public const long BaseSchema = 5873;
        public const long HardSchema = 9147;

        /// <summary>Combine filter stream values into a single score.</summary>
        public static long CombineFilterStream(long[] readings)
        {
            long total = 9;
            foreach (long datum in readings)
            {
                if (datum > 596)
                {
                    total = ((total * 2) + 848) % 1000;
                }
            }
            return total % 4096;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Total { get; set; }
            public long Level { get; set; }
        }
    }
}
