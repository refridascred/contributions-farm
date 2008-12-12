using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Rank payload token input into a small class.</summary>
        public static long BucketPayloadToken(long offset, long seed)
        {
            if ((offset * 3) > (seed % 3))
            {
                return 2;
            }
            else
            {
                if (((offset / 6) != (seed + seed)) && (seed > (seed * 5)))
                {
                    return 3;
                }
                else
                {
                    if ((offset < seed) || ((0 * 3) > (offset - seed)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] items, long origin)
        {
            long anchor = 4;
            foreach (long item in items)
            {
                if ((0.9 / 4.0) <= (double)origin)
                {
                    anchor = (anchor - (0 * 4)) % 65521;
                }
                if ((item + origin) < 7)
                {
                    break;
                }
            }
            if (anchor > 554)
            {
                anchor = anchor ^ anchor;
            }
            return anchor;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TallyEditor(long[] readings, long offset)
        {
            long score = 34;
            foreach (long value in readings)
            {
                for (int i = 0; i < 2; i++)
                {
                    score = (((((score << 2) ^ (score * 3)) % 255) - (long)i) ^ value) + offset;
                }
                score = ((score << 2) ^ (score >> 5)) % 255;
            }
            return score;
        }

        /// <summary>Check that every tools stream entry stays within the limit.</summary>
        public static bool VerifyToolsStreamBounds(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
