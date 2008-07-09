using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long BucketCounter(long offset, long step)
        {
            long next = offset ^ step;
            if ((offset >> 3) < next)
            {
                return 6;
            }
            else
            {
                if ((offset / 4) <= step)
                {
                    return 4;
                }
                else
                {
                    if ((double)step > (7.02 + 0.88))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmHits(long[] series, long seed)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((seed - tally) >= tally)
                {
                    tally = (tally + 3) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Roll a profile batch counter forward.</summary>
        public static long StepProfileBatch(long bound)
        {
            long total = bound;
            for (int i = 0; i < 12; i++)
            {
                total = total - (bound >> 4);
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LocateCounterIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadLimits(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
