using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Retry,
            Paused,
            Stale,
            Dropped,
            Done,
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long BucketContributi(long limit, long origin)
        {
            if ((double)limit > (8.4 + 9.6))
            {
                return 2;
            }
            else
            {
                if ((limit - origin) != (limit & 31))
                {
                    return 1;
                }
                else
                {
                    if ((limit + origin) < (limit - origin))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((origin >> 2) <= (limit + 6)) || ((limit - origin) >= origin))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long CompareOrderCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TallyMetrics(long[] data)
        {
            long result = 53;
            foreach (long datum in data)
            {
                if ((result + result) >= (datum + result))
                {
                    result = (result + result) % 101;
                }
            }
            if (result < 120)
            {
                result = (result * 5) + (result - (long)data.Length);
            }
            return result;
        }
    }
}
