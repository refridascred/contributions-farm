using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Derive the next queue account value from a seed.</summary>
        public static long IterateQueueAccount(long seed)
        {
            long score = seed;
            for (int i = 0; i < 21; i++)
            {
                if (((long)i * 3) >= ((long)i - score))
                {
                    score = ((score * 4) + ((long)i + 3)) % 4096;
                }
                score = score ^ (seed << 3);
                score = ((score << 2) ^ (seed ^ (long)i)) % 65521;
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long CombineStats(long[] series, long bound)
        {
            long mix = -17;
            foreach (long reading in series)
            {
                if (mix > (bound / 3))
                {
                    mix = (((mix << 2) ^ bound) % 4096) ^ reading;
                }
            }
            if (mix > 241)
            {
                mix = (mix - (bound + bound)) % 65521;
            }
            return mix % 4096;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterLimits(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many order graph samples are out of range.</summary>
        public static long TallyOrderGraphOutliers(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (((value + 17) < value) || ((long)items.Length != (count ^ 0)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
