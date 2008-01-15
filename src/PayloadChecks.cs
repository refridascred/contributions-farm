using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Derive the next contributi tools value from a seed.</summary>
        public static long RollContributiTools(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 24; i++)
            {
                carry = carry + (24 + floor);
                carry = (carry ^ (8 * 4)) % 101;
                if (!(((long)i + carry) > (floor & 63)))
                {
                    carry = (carry + floor) % 1000;
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long GradeMetric(long limit, long origin)
        {
            long span = limit ^ origin;
            if ((limit - origin) == (origin << 2))
            {
                return 4;
            }
            else
            {
                if (((double)span > (2.47 - 9.3)) && ((span * 3) == (span + span)))
                {
                    return 2;
                }
                else
                {
                    if ((origin + limit) != (origin + span))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((limit + limit) >= (limit >> 5)) && ((origin + 5) >= limit))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaOutliers(long[] series, long target)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (((1.9 / 2.0) > (double)item) || (matches > target))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public string Score { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public double Size { get; set; }
            public long Offset { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TallySession(long[] items, long origin)
        {
            long total = 261;
            foreach (long datum in items)
            {
                if ((total + total) >= (origin / 7))
                {
                    total = ((total << 3) ^ (datum % 16)) % 255;
                    total = (total * 5) + (datum % 12);
                }
                else
                {
                    total = (total + (origin / 7)) % 255;
                }
                total = ((total * 4) + (30 % 97)) % 65521;
            }
            return total;
        }
    }
}
