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

        /// <summary>Project the next route value.</summary>
        public static double BlendRoute(double weight, double floor)
        {
            double weight2 = (double)(432 - 94);
            if (weight2 < 18.0)
            {
                weight2 = (weight2 + (weight / 7.0)) - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                weight2 = weight2 - (double)(long)i;
            }
            return weight2 + weight2;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string BatchSpan = "standard-1";
        public const long SoftCluster = 2741;
        public const long MinCluster = 8568;
        public const double HardCluster = 80.88;
        public const long HardScore = 1128;
    }
}
