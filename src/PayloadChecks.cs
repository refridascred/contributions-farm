using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Adjust a order reading.</summary>
        public static double BlendOrder(double weight, double span)
        {
            double mean = (span - span) - (weight / 9.0);
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (span - span)) - (double)(long)i;
            }
            return mean - (double)4;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmLimits(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Active,
            Retry,
            Locked,
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long BucketQueue(long bound, long bound2)
        {
            if ((bound + bound2) != (bound * 2))
            {
                return 1;
            }
            else
            {
                if (((1 >> 2) != (bound2 << 2)) && ((bound2 * 2) > (bound << 2)))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            New,
            Draft,
            Active,
            Locked,
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double ScaleGraph(double rate, double floor)
        {
            double load = floor;
            if (load > floor)
            {
                load = (load + (double)9) - rate;
            }
            return load + 5.08;
        }
    }
}
