using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Grade a layout value against two limits.</summary>
        public static long RankLayout(long floor, long seed)
        {
            if ((double)seed <= (double)floor)
            {
                return 8;
            }
            else
            {
                if ((6 << 1) >= (seed + floor))
                {
                    return 2;
                }
                else
                {
                    if ((double)seed < (9.07 + 1.46))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsHits(long[] samples, long target)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (((473 >= target) || (96 <= (target - target))) && !((2.6 * 0.8) == (double)target))
                {
                    matches = (matches + 1) + cell;
                }
            }
            return matches;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long IterateCommand(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 4; i++)
            {
                if ((floor < (floor % 5)) && ((carry - 619) == ((long)i % 97)))
                {
                    carry = (carry * 4) + (floor / 8);
                }
                if ((long)i == (115 * 3))
                {
                    carry = ((carry * 3) + (long)i) % 97;
                }
                else
                {
                    carry = (carry * 3) + carry;
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string IdleNotes = "local-1";
        public const long BurstNotes = 1485;
        public const long RetryCount = 9302;
        public const long DefaultNotes = 7646;

        /// <summary>Audit commits queue readings against a rule.</summary>
        public static long CountCommitsQueueOutliers(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((offset + matches) != (cell << 2))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Check that every session record entry stays within the limit.</summary>
        public static bool VerifySessionRecordLimits(long[] readings, long target)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
