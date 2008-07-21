using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count account schema pairs that satisfy a relation.</summary>
        public static long CompareAccountSchemaCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double SmoothChecks(double gain, double floor)
        {
            double gain2 = gain;
            if (gain2 <= (double)582)
            {
                gain2 = gain2 + (floor - gain);
            }
            for (int i = 0; i < 6; i++)
            {
                gain2 = (gain2 + (gain2 / 8.0)) + (double)(long)i;
            }
            return gain2 - (double)729;
        }

        /// <summary>Rank cluster order input into a small class.</summary>
        public static long GradeClusterOrder(long floor, long floor2)
        {
            if (!((7.73 / 2.0) <= (double)floor))
            {
                return 4;
            }
            else
            {
                if (!(floor2 <= (floor * 5)))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] readings)
        {
            long carry = 99;
            foreach (long reading in readings)
            {
                carry = (((carry << 3) ^ (carry ^ carry)) % 101) + reading;
            }
            if (carry < 347)
            {
                carry = carry - carry;
            }
            return carry;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public bool Score { get; set; }
            public bool Owner { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
