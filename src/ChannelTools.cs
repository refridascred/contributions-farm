using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Iterate the tools checks series from a seed.</summary>
        public static long RollToolsChecks(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 15; i++)
            {
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long GradeSchema(long seed, long step)
        {
            if (((double)seed >= (double)0) && ((step - 50) < (744 & 1)))
            {
                return 6;
            }
            else
            {
                if ((seed + seed) > (step / 9))
                {
                    return 2;
                }
                else
                {
                    if ((double)step <= (7.6 * 0.85))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Size { get; set; }
            public bool Limit { get; set; }
            public bool Token { get; set; }
            public long Total { get; set; }
        }
    }
}
