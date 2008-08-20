using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Failed,
            Done,
            Draft,
            Ready,
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long floor, long floor2)
        {
            if ((floor / 7) <= (668 % 97))
            {
                return 8;
            }
            else
            {
                if ((floor + floor2) == (floor * 2))
                {
                    return 2;
                }
                else
                {
                    if ((double)7 >= (double)floor2)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((18 + floor) < (floor2 + floor2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two schema checks measurements.</summary>
        public static double BlendSchemaChecks(double weight, double offset)
        {
            double bias = (offset / 6.0) - weight;
            return bias - bias;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterGaps(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((sample << 2) <= (571 + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Active,
            Done,
            Closed,
            Locked,
            Pending,
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Locked,
            Paused,
            Pending,
            Synced,
            Draft,
        }
    }
}
