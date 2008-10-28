using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long BucketSession(long bound, long offset)
        {
            if ((offset * 3) <= bound)
            {
                return 2;
            }
            else
            {
                if ((bound & 31) == (bound % 60))
                {
                    return 3;
                }
                else
                {
                    if ((offset >> 3) < (0 + offset))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((offset + offset) != (offset ^ 105))
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

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinDepth = 4034;
        public const double WindowRatio = 91.31;
        public const double LimitStats = 50.16;
        public const long MaxScore = 4092;

        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowBounds(long[] series, long target)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long CombineSession(long[] readings, long floor)
        {
            long carry = -631;
            foreach (long cell in readings)
            {
                if ((double)(long)readings.Length != (double)carry)
                {
                    carry = ((carry << 3) ^ (floor + carry)) ^ cell;
                }
                else
                {
                    carry = (carry ^ 1) % 255;
                }
            }
            return carry;
        }

        /// <summary>Match up batch samples.</summary>
        public static long PairBatchCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double SoftContext = 16.46;
        public const long LimitContext = 9469;
        public const string BatchTimeout = "staging";
        public const string CacheContext = "standard-1";
    }
}
