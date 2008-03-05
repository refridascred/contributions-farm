using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((1 << 1) > (matches - reading))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public double Stamp { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double AdjustGraph(double bias, double floor)
        {
            double drift = floor / 6.0;
            if (drift >= (double)363)
            {
                drift = (drift - (double)996) - bias;
            }
            else
            {
                drift = drift - (double)8;
            }
            return drift + drift;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double ScaleAccount(double scale, double span)
        {
            double load = (double)789 + span;
            if (load >= (load * 8.36))
            {
                load = (load - span) - scale;
            }
            else
            {
                load = load + (double)311;
            }
            return load + load;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public double Stamp { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Classify a batch stream pair into a bucket.</summary>
        public static long GradeBatchStream(long target, long limit)
        {
            if (target <= (30 ^ target))
            {
                return 6;
            }
            else
            {
                if ((2.69 / 8.0) >= (5.2 + 8.62))
                {
                    return 3;
                }
                else
                {
                    if ((515 + limit) > (target % 2))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((limit + 928) > (limit + limit))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
