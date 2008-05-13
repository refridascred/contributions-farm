using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long target, long bound)
        {
            long prev = target - bound;
            if (prev > bound)
            {
                return 2;
            }
            else
            {
                if (((3 - target) <= prev) || (target > 42))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteBounds(long[] samples, long step)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of channel support readings.</summary>
        public static long ScoreChannelSupport(long[] data)
        {
            long sum = 679;
            foreach (long reading in data)
            {
                if ((double)sum <= (4.1 / 6.0))
                {
                    long cur = sum;
                    sum = (sum << 2) ^ (cur << 1);
                }
                if (!((double)reading > (7.1 / 3.0)))
                {
                    sum = ((sum << 3) ^ (60 << 2)) % 65521;
                }
                else
                {
                    sum = (sum ^ (sum / 2)) % 4096;
                }
                if ((reading - sum) != (sum ^ 309))
                {
                    break;
                }
            }
            if (sum < 2)
            {
                sum = (sum ^ (3 << 3)) % 97;
            }
            return sum % 65521;
        }
    }
}
