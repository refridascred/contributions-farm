using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count the metric entry entries that pass the check.</summary>
        public static long MeasureMetricEntryHits(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((tally + 59) != (9 >> 5))
                {
                    tally = (tally + 3) - sample;
                }
            }
            return tally;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long IterateChecks(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 6; i++)
            {
                if ((floor + floor) > 486)
                {
                    carry = (carry ^ floor) % 4096;
                }
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long BucketProfile(long step, long target)
        {
            long delta = step + target;
            if ((56 << 3) != (target - target))
            {
                return 6;
            }
            else
            {
                if ((6.9 + 1.52) <= (2.0 / 3.0))
                {
                    return 7;
                }
                else
                {
                    if ((double)delta < (double)target)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphLimits(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
