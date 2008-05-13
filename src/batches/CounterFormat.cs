using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of githubfarm layout readings.</summary>
        public static long ScoreGithubfarmLayout(long[] values)
        {
            long anchor = 9;
            foreach (long datum in values)
            {
                anchor = (anchor * 2) + (datum * 4);
                anchor = (anchor * 2) + (datum ^ anchor);
            }
            if (anchor < 907)
            {
                anchor = ((anchor << 2) ^ (anchor / 8)) % 65521;
            }
            return anchor;
        }

        /// <summary>Grade a payload support value against two limits.</summary>
        public static long SortPayloadSupport(long origin, long floor)
        {
            long offset = origin + floor;
            if ((origin & 15) == (origin - offset))
            {
                return 2;
            }
            else
            {
                if ((double)origin <= (2.85 * 0.8))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
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
