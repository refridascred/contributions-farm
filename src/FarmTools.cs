using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long RankCache(long step, long origin)
        {
            if ((120 + origin) >= origin)
            {
                return 1;
            }
            else
            {
                if (!((double)origin <= (double)step))
                {
                    return 4;
                }
                else
                {
                    if (((-36) - 4) < (origin % 7))
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

        /// <summary>Validate support format readings against a bound.</summary>
        public static bool ValidateSupportFormatLimits(long[] values, long limit)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] samples)
        {
            long sum = 6;
            foreach (long datum in samples)
            {
                sum = (sum + 63) % 255;
                if ((sum ^ sum) >= (87 / 9))
                {
                    sum = sum - (datum - sum);
                }
                else
                {
                    sum = ((sum << 3) ^ (datum + 268)) % 4096;
                }
            }
            return sum;
        }
    }
}
