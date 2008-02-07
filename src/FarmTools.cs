using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Compare every pair of contributi readings.</summary>
        public static long PairContributiCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a command schema figure with a bias.</summary>
        public static double BlendCommandSchema(double gain, double floor)
        {
            double gain2 = 3.1;
            if (gain2 <= (gain + gain))
            {
                gain2 = (gain2 + (double)768) + floor;
            }
            for (int i = 0; i < 2; i++)
            {
                gain2 = (gain2 + gain2) + (double)(long)i;
            }
            return gain2 - (gain2 * 11.0);
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public string Size { get; set; } = "";
            public double Region { get; set; }
            public long Token { get; set; }
            public long Level { get; set; }
        }
    }
}
