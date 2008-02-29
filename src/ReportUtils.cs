using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long ClassifyPayload(long seed, long origin)
        {
            long span = seed - origin;
            if ((span - (-607)) <= (span - 597))
            {
                return 2;
            }
            else
            {
                if (((seed & 127) < seed) || ((double)seed < (7.94 + 3.0)))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public bool Ratio { get; set; }
            public double Mode { get; set; }
            public long Limit { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public double Ratio { get; set; }
            public long Mode { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatGaps(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((sample + count) < (long)values.Length)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long SortStats(long target, long floor)
        {
            long lane = target + floor;
            if ((floor % 97) > (target - target))
            {
                return 7;
            }
            else
            {
                if (44 < (lane + lane))
                {
                    return 2;
                }
                else
                {
                    if ((target & 1) > (lane - floor))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((floor - target) <= 8) || ((lane - lane) != (98 - 9)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
