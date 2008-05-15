using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesOutliers(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (((long)readings.Length >= offset) || ((entry & 7) != (matches ^ matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Check that every filter already entry stays within the limit.</summary>
        public static bool ValidateFilterAlreadyRange(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next order value.</summary>
        public static double AdjustOrder(double bias, double offset)
        {
            double rate = (double)(31 - 4);
            if (rate > offset)
            {
                rate = rate + bias;
            }
            else
            {
                rate = rate - (double)35;
            }
            return rate + (double)1;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long target, long offset)
        {
            long bound = target - offset;
            if ((offset >> 1) < (target + 56))
            {
                return 4;
            }
            else
            {
                if ((target * 2) >= (bound ^ bound))
                {
                    return 5;
                }
                else
                {
                    if ((target * 3) > (bound * 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if (bound >= (target + target))
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
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double ProjectNotes(double gain, double offset)
        {
            double weight = gain;
            if (weight <= gain)
            {
                weight = weight + (20.0 - gain);
            }
            else
            {
                weight = weight - offset;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - (offset + gain)) + (double)(long)i;
            }
            return weight - (1.94 + offset);
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorGaps(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((tally - tally) > (tally % 97))
                {
                    tally = (tally + 1) ^ reading;
                }
            }
            return tally;
        }
    }
}
