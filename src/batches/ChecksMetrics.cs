using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Compare every pair of entry readings.</summary>
        public static long OverlapEntryCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepBuffer = 3042;
        public const long WindowInterval = 55;
        public const double HardBuffer = 19.46;

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool VerifyChannelBounds(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileHits(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((seed << 1) <= ((long)readings.Length + entry))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileHits(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((double)sample <= (9.0 * 5.2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long SortMetrics(long bound, long bound2)
        {
            if ((bound + bound) <= (66 + bound2))
            {
                return 8;
            }
            else
            {
                if ((bound >> 4) <= (bound2 + bound))
                {
                    return 1;
                }
                else
                {
                    if ((bound2 * 5) > 4)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((bound2 - bound) == (bound + bound))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
