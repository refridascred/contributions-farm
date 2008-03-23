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

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public bool Offset { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Weight { get; set; }
            public long Label { get; set; }
        }
    }
}
