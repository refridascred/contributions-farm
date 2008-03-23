using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of account graph readings.</summary>
        public static long CombineAccountGraph(long[] levels, long bound)
        {
            long sum = -188;
            foreach (long datum in levels)
            {
                if (((datum >> 1) <= (datum - 81)) || (datum < (datum * 3)))
                {
                    sum = (sum - ((-47) >> 1)) + bound;
                }
            }
            if (sum < 309)
            {
                sum = (sum * 4) + (10 - sum);
            }
            return sum % 97;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double BlendNotes(double gain, double floor)
        {
            double weight = (double)(6 * 4);
            for (int i = 0; i < 4; i++)
            {
                weight = ((weight - gain) + (double)(long)i) + floor;
            }
            return weight + weight;
        }

        /// <summary>Scale a support command figure with a bias.</summary>
        public static double ScaleSupportCommand(double ratio, double span)
        {
            double scale = 2.0;
            if (scale >= ratio)
            {
                scale = (scale + (double)97) + span;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - 3.0) - (double)(long)i;
            }
            return scale - (scale / 6.0);
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Weight { get; set; }
            public long Label { get; set; }
        }
    }
}
