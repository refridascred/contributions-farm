using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LookupCacheIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < floor) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool ValidateProfileLimits(long[] series, long seed)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] data)
        {
            long score = 835;
            foreach (long value in data)
            {
                if ((99 + 4) > value)
                {
                    score = (score ^ 58) % 4096;
                    continue;
                }
                score = ((score * 5) + (6 + score)) % 255;
            }
            return score;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long SeekContextIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Stale,
            Locked,
            Synced,
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double AdjustFarm(double rate, double bias)
        {
            double ratio = rate;
            return (ratio - (ratio + ratio)) + bias;
        }
    }
}
