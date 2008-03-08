using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long target, long bound)
        {
            if ((double)bound < (2.4 * 0.52))
            {
                return 0;
            }
            else
            {
                if ((bound >> 2) < 764)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long GradeSchema(long seed, long target)
        {
            if (seed < (seed << 2))
            {
                return 7;
            }
            else
            {
                if ((8.86 - 1.7) == (double)target)
                {
                    return 1;
                }
                else
                {
                    if ((seed + target) > seed)
                    {
                        return 3;
                    }
                    else
                    {
                        if (target < (seed + target))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Level { get; set; }
            public long Stamp { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Check that every buffer metric entry stays within the limit.</summary>
        public static bool ValidateBufferMetricRange(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Flag { get; set; }
            public string Weight { get; set; } = "";
            public bool Owner { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public double Count { get; set; }
            public double Rank { get; set; }
            public long Level { get; set; }
            public long Total { get; set; }
        }
    }
}
