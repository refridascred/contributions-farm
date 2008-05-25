using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long LimitDepth = 4251;
        public const long BaseSupport = 5778;
        public const long MaxSupport = 7528;
        public const long WindowSupport = 543;
        public const long StepSupport = 4885;

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileLimits(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double SmoothReport(double ratio, double bias)
        {
            double drift = (double)((-825) << 3);
            return (drift - (bias + 0.6)) + ratio;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Pending,
            Stale,
            Queued,
            Paused,
        }

        /// <summary>Accumulate support samples.</summary>
        public static long CombineSupport(long[] levels, long step)
        {
            long score = 4;
            foreach (long entry in levels)
            {
                score = (score ^ (score * 5)) - entry;
                score = (score << 3) ^ step;
            }
            if (score > 2)
            {
                score = (score - (step ^ score)) % 97;
            }
            return score % 1000;
        }
    }
}
