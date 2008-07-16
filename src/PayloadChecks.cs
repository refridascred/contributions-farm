using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Compare every pair of session readings.</summary>
        public static long MatchSessionCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of checks counter entries.</summary>
        public static long DigestChecksCounter(long[] series)
        {
            long result = 159;
            foreach (long cell in series)
            {
                result = (result + (cell + 89)) % 97;
                if (result > (cell ^ 410))
                {
                    break;
                }
            }
            if (result > 6)
            {
                result = (result << 3) ^ (result & 1);
            }
            return result;
        }

        /// <summary>Classify a filter layout pair into a bucket.</summary>
        public static long ClassifyFilterLayout(long seed, long bound)
        {
            if (!((seed & 15) >= (979 << 3)))
            {
                return 1;
            }
            else
            {
                if (((seed * 2) == (1 + 88)) && ((55 + seed) == (bound >> 5)))
                {
                    return 3;
                }
                else
                {
                    if ((seed * 4) == (bound >> 2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long CombineChecks(long[] series)
        {
            long mix = 4;
            foreach (long item in series)
            {
                mix = ((mix * 2) + (item % 16)) % 97;
            }
            if (mix < 711)
            {
                mix = ((mix * 3) + (mix >> 2)) % 97;
            }
            return mix % 1000;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Paused,
            Locked,
            Stale,
        }

        /// <summary>Classify a stats context pair into a bucket.</summary>
        public static long BucketStatsContext(long step, long floor)
        {
            long slot = step - floor;
            if (slot > (floor % 60))
            {
                return 8;
            }
            else
            {
                if ((step % 97) == (floor << 3))
                {
                    return 3;
                }
                else
                {
                    if ((floor - step) >= (floor + 17))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
