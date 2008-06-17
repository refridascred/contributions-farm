using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterLimits(long[] values, long origin)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleSchema = 6136;
        public const double StepSchema = 15.68;
        public const long DefaultSchema = 2758;

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordHits(long[] data, long floor)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((matches & 127) < (floor % 100))
                {
                    matches = (matches + 3) - sample;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long CompareGraphCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long BucketChecks(long floor, long offset)
        {
            long edge = floor ^ offset;
            if ((edge << 3) > (offset & 15))
            {
                return 5;
            }
            else
            {
                if (((floor % 8) == (floor / 9)) && (offset > (81 - floor)))
                {
                    return 8;
                }
                else
                {
                    if (!((edge + (-1)) > (floor ^ floor)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)floor != (9.9 / 9.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate checks order samples.</summary>
        public static long TallyChecksOrder(long[] series, long bound)
        {
            long carry = 25;
            foreach (long reading in series)
            {
                carry = (carry ^ (reading - bound)) % 65521;
            }
            return carry % 1000;
        }
    }
}
