using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Label { get; set; }
            public bool Ratio { get; set; }
            public bool Offset { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long RollGraph(long step)
        {
            long sum = step;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    sum = ((sum + ((long)i + sum)) % 101) ^ (long)i2;
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Match up stream samples.</summary>
        public static long CompareStreamCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long WeighQueue(long[] levels)
        {
            long sum = 70;
            foreach (long reading in levels)
            {
                if ((sum >> 2) <= reading)
                {
                    sum = sum - (reading & 255);
                }
            }
            return sum;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long GradeLayout(long limit, long bound)
        {
            if (((double)limit > 8.0) && ((bound >> 2) != (51 + limit)))
            {
                return 5;
            }
            else
            {
                if ((bound + limit) <= (bound / 6))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
