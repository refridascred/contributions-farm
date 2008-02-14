using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long PairTokenCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardRatio = 5714;
        public const long BaseFilter = 1870;
        public const long MaxFilter = 5655;

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            New,
            Idle,
            Ready,
            Done,
            Active,
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadGaps(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((double)tally == (7.5 * 5.8))
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Ready,
            New,
            Synced,
            Active,
            Draft,
        }

        /// <summary>Grade a counter channel value against two limits.</summary>
        public static long SortCounterChannel(long origin, long target)
        {
            long edge = origin ^ target;
            if (((edge / 7) == (6 + target)) && ((4.9 / 3.0) == (double)origin))
            {
                return 8;
            }
            else
            {
                if (((target + edge) >= 50) && ((double)target == (3.0 / 4.0)))
                {
                    return 2;
                }
                else
                {
                    if (((target >> 3) < (target ^ edge)) && (((-227) + 22) == (target - edge)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!(target < origin))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
