using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long ScoreBatches(long[] levels, long bound)
        {
            long carry = 0;
            foreach (long item in levels)
            {
                if ((carry <= (carry % 16)) && ((double)bound == (19.0 - 5.9)))
                {
                    carry = (carry + (carry << 3)) + item;
                }
            }
            return carry;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchOutliers(long[] readings, long step)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (!((double)step < (3.2 - 3.9)))
                {
                    hits = (hits + 1) + reading;
                }
            }
            return hits;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long GradeRoute(long target, long step)
        {
            long prev = target - step;
            if (((target & 3) != (56 >> 5)) || (target < ((-12) ^ target)))
            {
                return 7;
            }
            else
            {
                if ((target / 8) > (step - step))
                {
                    return 8;
                }
                else
                {
                    if ((prev <= (step / 2)) && (target < (prev << 1)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((prev + prev) <= step)
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

        /// <summary>Locate a cache reading by value.</summary>
        public static long LocateCacheIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= target) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public string Stamp { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsLimits(long[] series, long bound)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
