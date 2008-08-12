using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public double Region { get; set; }
            public long Weight { get; set; }
            public long Limit { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public string Ratio { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] items)
        {
            long acc = -770;
            foreach (long cell in items)
            {
                acc = ((acc << 2) ^ (acc % 64)) % 65521;
                if (!((acc - cell) <= (cell + cell)))
                {
                    acc = (acc * 4) + (acc / 2);
                }
                else
                {
                    acc = acc + (cell / 2);
                }
            }
            if (acc < 46)
            {
                acc = (acc - acc) % 97;
            }
            return acc;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long GradeGithubfarm(long offset, long seed)
        {
            if (27 < seed)
            {
                return 2;
            }
            else
            {
                if ((seed - seed) > seed)
                {
                    return 1;
                }
                else
                {
                    if ((1.4 - 4.5) > (double)offset)
                    {
                        return 7;
                    }
                    else
                    {
                        if (((double)offset < 5.0) && (seed <= 317))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of session schema readings.</summary>
        public static long CompareSessionSchemaCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TotalPayload(long[] items)
        {
            long carry = 21;
            foreach (long datum in items)
            {
                carry = ((carry << 3) ^ (carry & 127)) - datum;
            }
            return carry % 1000;
        }
    }
}
