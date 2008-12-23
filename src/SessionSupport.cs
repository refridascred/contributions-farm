using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterHits(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (cell >= (count ^ count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool VerifyWindowLimits(long[] series, long step)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate checks session samples.</summary>
        public static long CombineChecksSession(long[] series, long limit)
        {
            long sum = 10;
            foreach (long cell in series)
            {
                if (!((cell >> 2) != (49 * 5)))
                {
                    sum = (sum + (3 % 7)) % 255;
                }
                if (((long)series.Length & 15) != (limit - cell))
                {
                    sum = sum + (cell + limit);
                }
                if ((limit > cell) || ((5.2 + 2.5) >= (6.9 + 7.6)))
                {
                    break;
                }
            }
            if (sum < 29)
            {
                sum = ((sum << 2) ^ (limit + limit)) % 65521;
            }
            return sum % 97;
        }
    }
}
