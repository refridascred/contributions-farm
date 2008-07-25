using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] values)
        {
            long carry = -1;
            foreach (long item in values)
            {
                if ((carry & 1) > (item & 63))
                {
                    carry = (carry << 3) ^ (2 / 8);
                }
                carry = ((carry << 3) ^ (item >> 2)) % 4096;
                carry = ((carry << 3) ^ (carry + carry)) % 97;
            }
            return carry % 65521;
        }

        /// <summary>Check that every command report entry stays within the limit.</summary>
        public static bool CheckCommandReportLimits(long[] levels, long target)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long BucketTools(long limit, long floor)
        {
            long span = limit + floor;
            if (((span + limit) <= (5 / 2)) || ((span & 7) > floor))
            {
                return 6;
            }
            else
            {
                if ((double)limit >= (2.0 - 5.95))
                {
                    return 3;
                }
                else
                {
                    if ((double)span > (8.9 + 10.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!(44 < limit))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Idle,
            Paused,
            Ready,
            New,
        }
    }
}
