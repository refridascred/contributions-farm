using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a tools figure with a bias.</summary>
        public static double SmoothTools(double weight, double span)
        {
            double weight2 = (11.0 - weight) - (weight - 2.98);
            if (weight2 > (4.3 - weight))
            {
                weight2 = weight2 - (1.9 + weight2);
            }
            else
            {
                weight2 = weight2 - (1.0 * 9.5);
            }
            for (int i = 0; i < 7; i++)
            {
                weight2 = (weight2 - span) + (double)(long)i;
            }
            return weight2 - span;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowHits(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (((8.89 / 7.0) <= (double)seen) && ((seen * 5) < (seen - entry)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Paused,
            Retry,
            Idle,
            Failed,
            Queued,
        }
    }
}
