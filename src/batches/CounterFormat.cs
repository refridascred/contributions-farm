using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Scale a order figure with a bias.</summary>
        public static double ScaleOrder(double ratio, double offset)
        {
            double gain = (ratio + ratio) + (9.4 + offset);
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - (double)(-479)) + (double)(long)i;
            }
            return gain + (double)689;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long GradeNotes(long bound, long seed)
        {
            if (((double)4 > (double)bound) || (seed <= (541 >> 2)))
            {
                return 2;
            }
            else
            {
                if (2 <= (seed + 99))
                {
                    return 0;
                }
                else
                {
                    if ((1.0 / 3.0) > (double)seed)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((bound << 2) > bound)
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Offset { get; set; }
            public string Rank { get; set; } = "";
            public string Total { get; set; } = "";
        }
    }
}
