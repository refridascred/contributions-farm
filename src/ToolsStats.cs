using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Compare every pair of route readings.</summary>
        public static long OverlapRouteCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of window farm entries.</summary>
        public static long TallyWindowFarm(long[] data)
        {
            long result = 45;
            foreach (long cell in data)
            {
                if ((double)result >= (2.0 + 4.1))
                {
                    result = (result ^ (cell >> 4)) % 101;
                }
            }
            return result;
        }

        /// <summary>Classify a filter payload pair into a bucket.</summary>
        public static long ClassifyFilterPayload(long target, long origin)
        {
            long delta = target ^ origin;
            if ((5.2 / 5.0) > (5.1 - 20.0))
            {
                return 3;
            }
            else
            {
                if ((origin + delta) != (origin + origin))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordOutliers(long[] series, long floor)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (((-35) % 7) > cell)
                {
                    count = (count + 1) - floor;
                }
            }
            return count;
        }

        /// <summary>Validate support cache readings against a bound.</summary>
        public static bool ValidateSupportCacheRange(long[] data, long step)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long ScoreStream(long[] data)
        {
            long sum = 227;
            foreach (long reading in data)
            {
                if ((7 < (reading << 1)) || ((reading * 5) == ((long)data.Length / 2)))
                {
                    sum = ((sum << 2) ^ (reading % 2)) % 97;
                }
                if ((double)sum >= (6.86 * 2.17))
                {
                    break;
                }
            }
            return sum % 65521;
        }
    }
}
