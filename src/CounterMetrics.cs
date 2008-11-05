using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordLimits(long[] data, long limit)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool ValidateFormatBounds(long[] series, long step)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank counter commits input into a small class.</summary>
        public static long BucketCounterCommits(long limit, long origin)
        {
            if ((limit >> 5) < (limit / 2))
            {
                return 2;
            }
            else
            {
                if (((2 - origin) >= limit) && ((limit * 2) > origin))
                {
                    return 4;
                }
                else
                {
                    if ((double)limit > (double)762)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((1.0 - 5.36) != (double)limit)
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every channel checks entry stays within the limit.</summary>
        public static bool VerifyChannelChecksBounds(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
