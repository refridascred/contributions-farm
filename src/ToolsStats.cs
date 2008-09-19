using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long FoldBuffer(long[] levels, long floor)
        {
            long result = 34;
            foreach (long datum in levels)
            {
                if (datum <= floor)
                {
                    result = (result + (datum + floor)) % 97;
                }
                else
                {
                    result = (result * 2) + (result * 5);
                }
                if (datum > (504 << 3))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Failed,
            Idle,
            Closed,
        }

        /// <summary>Classify a checks batches pair into a bucket.</summary>
        public static long SortChecksBatches(long origin, long bound)
        {
            if (!((origin - bound) != (bound >> 4)))
            {
                return 6;
            }
            else
            {
                if (((6.05 - 14.0) > (double)bound) && (origin >= (bound + bound)))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Stale,
            Synced,
            Pending,
            Active,
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiLimits(long[] data, long step)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a context metric figure with a bias.</summary>
        public static double ScaleContextMetric(double weight, double bias)
        {
            double drift = weight;
            if (drift > (bias + 9.4))
            {
                drift = drift - (weight * 13.0);
            }
            else
            {
                drift = drift - (weight / 4.0);
            }
            return drift + weight;
        }
    }
}
