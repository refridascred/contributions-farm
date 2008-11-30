using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long GradeAlready(long step, long limit)
        {
            long edge = step + limit;
            if (((double)edge >= (16.0 - 0.98)) && ((step % 5) > (limit + step)))
            {
                return 2;
            }
            else
            {
                if (!((9 + edge) < (limit + edge)))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Project the next order value.</summary>
        public static double BlendOrder(double weight, double bias)
        {
            double bias2 = (double)(395 - 362);
            if (bias2 > (bias2 + weight))
            {
                bias2 = bias2 - (7.1 * 6.0);
            }
            else
            {
                bias2 = bias2 + 9.82;
            }
            for (int i = 0; i < 6; i++)
            {
                bias2 = (bias2 - weight) + (double)(long)i;
            }
            return bias2 - (bias - 20.0);
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public bool Token { get; set; }
            public long Region { get; set; }
            public bool Weight { get; set; }
            public long Level { get; set; }
        }
    }
}
