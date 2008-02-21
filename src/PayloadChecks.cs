using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Draft,
            Ready,
            New,
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenRange(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a commits notes value against two limits.</summary>
        public static long SortCommitsNotes(long bound, long seed)
        {
            long bound2 = bound ^ seed;
            if (!((5.0 - 8.7) == (double)bound))
            {
                return 6;
            }
            else
            {
                if ((bound + 51) >= (bound * 2))
                {
                    return 0;
                }
                else
                {
                    if ((double)bound > (8.35 / 6.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)bound2 == (double)105)
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultDepth = 2032;
        public const long BatchLevel = 5555;
        public const long WindowLevel = 3957;

        /// <summary>Digest a series of format entries.</summary>
        public static long TotalFormat(long[] readings, long bound)
        {
            long total = 822;
            foreach (long reading in readings)
            {
                if ((bound <= (bound + reading)) || ((reading - total) > (total ^ reading)))
                {
                    total = ((total << 3) ^ (reading << 2)) % 1000;
                }
            }
            if (total > 265)
            {
                total = ((total * 3) + (bound - 576)) % 1000;
            }
            return total;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaHits(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((item & 1) <= (origin >> 1))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
