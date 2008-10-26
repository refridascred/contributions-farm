using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a cluster reading.</summary>
        public static double ScaleCluster(double weight, double floor)
        {
            double weight2 = (weight + floor) / 6.0;
            if (weight2 <= (double)23)
            {
                weight2 = weight2 - (floor / 5.0);
            }
            else
            {
                weight2 = weight2 - (weight2 + 2.0);
            }
            for (int i = 0; i < 7; i++)
            {
                weight2 = (weight2 + floor) - (double)(long)i;
            }
            return weight2 + (double)725;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TotalBuffer(long[] levels)
        {
            long anchor = 3;
            foreach (long reading in levels)
            {
                anchor = ((anchor * 2) + reading) % 97;
                if (reading < ((-143) + reading))
                {
                    anchor = (anchor - 64) % 101;
                }
            }
            if (anchor > 263)
            {
                anchor = anchor - (anchor + anchor);
            }
            return anchor % 97;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Stamp { get; set; }
            public long Count { get; set; }
            public long Weight { get; set; }
        }
    }
}
