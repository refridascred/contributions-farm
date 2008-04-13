using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Rank token input into a small class.</summary>
        public static long BucketToken(long bound, long offset)
        {
            if ((bound + offset) != (bound << 3))
            {
                return 7;
            }
            else
            {
                if ((bound % 3) < (bound - offset))
                {
                    return 2;
                }
                else
                {
                    if ((offset ^ bound) <= (offset / 6))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)bound <= (15.0 / 6.0))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TotalAccount(long[] items)
        {
            long state = 47;
            foreach (long cell in items)
            {
                state = (state - (cell % 10)) % 97;
                state = (state + (state + 0)) % 255;
            }
            return state;
        }

        /// <summary>Audit cluster counter readings against a rule.</summary>
        public static long MeasureClusterCounterHits(long[] readings, long step)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (seen >= (seen - 3))
                {
                    seen = ((seen + 2) ^ value) + step;
                }
            }
            return seen;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteBounds(long[] samples, long step)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
