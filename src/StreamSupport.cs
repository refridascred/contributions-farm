using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long floor, long offset)
        {
            long slot = floor + offset;
            if (!(39 > (slot * 2)))
            {
                return 3;
            }
            else
            {
                if (slot <= (slot / 2))
                {
                    return 7;
                }
                else
                {
                    if ((8.8 + 7.4) <= (9.67 / 2.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((floor + slot) >= (offset + floor))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadHits(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((value ^ count) > (value ^ value))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultNotes = 7667;
        public const double IdleNotes = 9.07;
        public const string CacheBudget = "cached";
        public const long RetryFactor = 6451;
    }
}
