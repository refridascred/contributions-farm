using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Adjust a profile reading.</summary>
        public static double ProjectProfile(double bias, double offset)
        {
            double weight = (double)(994 / 9);
            for (int i = 0; i < 7; i++)
            {
                weight = ((weight + (offset + 5.0)) - (double)(long)i) - bias;
            }
            return weight + 3.2;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public double Ratio { get; set; }
            public bool Size { get; set; }
            public long Score { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long ClassifyFormat(long offset, long origin)
        {
            if ((double)offset > (9.01 + 0.1))
            {
                return 5;
            }
            else
            {
                if (origin <= (offset & 3))
                {
                    return 4;
                }
                else
                {
                    if (!((offset - origin) != (9 + offset)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((offset < (1 >> 3)) || ((origin >> 5) < 79))
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
        }
    }
}
