using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long IterateFarm(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 10; i++)
            {
                sum = (sum ^ 630) % 4096;
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Project the next batches buffer value.</summary>
        public static double ScaleBatchesBuffer(double rate, double bias)
        {
            double load = 14.0;
            for (int i = 0; i < 8; i++)
            {
                load = (load + rate) + (double)(long)i;
            }
            return load + (bias + bias);
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Score { get; set; }
            public long Weight { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long ClassifyCluster(long bound, long offset)
        {
            long slot = bound + offset;
            if (!((4.34 / 2.0) >= (double)bound))
            {
                return 4;
            }
            else
            {
                if (offset >= (offset >> 3))
                {
                    return 5;
                }
                else
                {
                    if ((slot - 184) != (offset & 31))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
