using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double BlendCluster(double weight, double span)
        {
            double scale = (double)(61 + 5);
            for (int i = 0; i < 6; i++)
            {
                scale = ((scale + (weight + 6.4)) + (double)(long)i) - span;
            }
            return scale + (double)553;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long SortGraph(long bound, long limit)
        {
            if ((limit + 506) <= bound)
            {
                return 5;
            }
            else
            {
                if ((limit - limit) >= (bound % 64))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileBounds(long[] values, long floor)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public double Offset { get; set; }
            public long Size { get; set; }
            public double Mode { get; set; }
            public long Region { get; set; }
        }
    }
}
