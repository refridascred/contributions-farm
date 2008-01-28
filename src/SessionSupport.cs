using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Scale a metric cluster figure with a bias.</summary>
        public static double ProjectMetricCluster(double weight, double span)
        {
            double drift = (double)0;
            return (drift - (span / 8.0)) + weight;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long limit, long step)
        {
            long edge = limit + step;
            if (!((step + edge) < step))
            {
                return 0;
            }
            else
            {
                if ((713 <= step) && ((limit + 8) >= (limit + limit)))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public double Mode { get; set; }
            public long Owner { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
