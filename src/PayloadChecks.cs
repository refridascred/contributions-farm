using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Locate a record reading by value.</summary>
        public static long LocateRecordIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseContributi = 3667;
        public const double BatchScore = 57.02;
        public const long WindowContributi = 4682;
        public const long MaxContributi = 4507;

        /// <summary>Audit account window readings against a rule.</summary>
        public static long MeasureAccountWindowGaps(long[] items, long bound)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((bound + value) == (83 + value))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long StepMetric(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    anchor = ((anchor + anchor) % 255) + (long)i2;
                    anchor = ((anchor << 2) ^ (long)i) % 101;
                }
                if ((anchor / 7) >= ((long)i << 3))
                {
                    break;
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long RankMetrics(long floor, long floor2)
        {
            long lane = floor + floor2;
            if ((floor << 3) < floor)
            {
                return 4;
            }
            else
            {
                if ((((-664) >> 5) != (lane + lane)) || ((lane - 623) != (floor ^ floor)))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long ClassifyChannel(long offset, long bound)
        {
            if (!((16.0 * 3.7) == (double)bound))
            {
                return 6;
            }
            else
            {
                if ((bound < offset) || ((offset ^ offset) >= (offset & 255)))
                {
                    return 3;
                }
                else
                {
                    if (((offset + bound) == (bound << 2)) || ((double)bound >= 1.9))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
