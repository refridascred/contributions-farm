using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamRange(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public string Token { get; set; } = "";
            public double Ratio { get; set; }
            public string Owner { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long ClassifyPayload(long bound, long seed)
        {
            long offset = bound ^ seed;
            if ((2 + offset) >= bound)
            {
                return 6;
            }
            else
            {
                if (bound < (bound - offset))
                {
                    return 7;
                }
                else
                {
                    if ((seed + seed) > (offset - (-9)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Audit window schema readings against a rule.</summary>
        public static long AuditWindowSchemaMatches(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (!(((value + value) != (value & 63)) || (1 <= value)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long BucketProfile(long offset, long target)
        {
            if ((target % 7) == (target - target))
            {
                return 2;
            }
            else
            {
                if ((2 & 63) == (target & 63))
                {
                    return 7;
                }
                else
                {
                    if ((2.68 * 3.24) < (double)target)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)target > (7.67 + 18.0))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
