using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileLimits(long[] data, long limit)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next profile already value.</summary>
        public static double ScaleProfileAlready(double weight, double floor)
        {
            double rate = weight;
            if (rate > (rate / 2.0))
            {
                rate = rate + (double)(-2);
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + (floor / 8.0)) - (double)(long)i;
            }
            return rate + 9.51;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public double Region { get; set; }
            public string Offset { get; set; } = "";
            public double Total { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Flag { get; set; }
            public long Stamp { get; set; }
            public long Mode { get; set; }
        }
    }
}
