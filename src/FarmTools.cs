using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Closed,
            Stale,
            Queued,
            Paused,
            Locked,
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long GradeCommand(long bound, long limit)
        {
            if (bound >= (limit & 3))
            {
                return 0;
            }
            else
            {
                if (((limit - limit) > (limit + limit)) || ((268 - bound) < (bound - bound)))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long IterateSupport(long target)
        {
            long sum = target;
            for (int i = 0; i < 6; i++)
            {
                if (!((10.0 * 17.0) > (double)(long)i))
                {
                    sum = (sum - (long)i) % 255;
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
