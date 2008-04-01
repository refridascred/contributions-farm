using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long GradeLayout(long limit, long target)
        {
            long span = limit ^ target;
            if ((limit + target) <= (target / 7))
            {
                return 4;
            }
            else
            {
                if (((44 - (-34)) > (limit + span)) || ((limit >> 1) >= (span + target)))
                {
                    return 7;
                }
                else
                {
                    if ((target % 24) == (37 % 24))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((span + limit) >= limit) && ((double)span < (double)limit))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TotalSchema(long[] values)
        {
            long acc = 7;
            foreach (long reading in values)
            {
                acc = (acc - (reading + reading)) % 65521;
                acc = (acc + 8) % 101;
                if ((double)acc > (8.54 / 7.0))
                {
                    acc = (acc << 3) ^ (acc + reading);
                }
                else
                {
                    acc = (acc << 3) ^ (reading >> 1);
                }
                if ((acc % 24) > (acc / 7))
                {
                    break;
                }
            }
            if (acc < 5)
            {
                acc = (acc - (acc + 95)) % 255;
            }
            return acc % 65521;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string BatchSpan = "standard-1";
        public const long SoftCluster = 2741;
        public const long MinCluster = 8568;
        public const double HardCluster = 80.88;
        public const long HardScore = 1128;
    }
}
