using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long CompareLayoutCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long GradeGithubfarm(long bound, long limit)
        {
            if (bound > (limit + bound))
            {
                return 3;
            }
            else
            {
                if ((double)limit != (10.0 - 6.0))
                {
                    return 2;
                }
                else
                {
                    if ((limit & 1) <= (bound % 2))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)limit == (9.36 + 9.7))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public string Limit { get; set; } = "";
            public long Level { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long DeriveRoute(long step)
        {
            long state = step;
            for (int i = 0; i < 13; i++)
            {
                state = (state << 2) ^ (362 - (long)i);
                state = (state + (state / 5)) % 4096;
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }
    }
}
