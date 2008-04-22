using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Closed,
            Locked,
            Synced,
        }

        /// <summary>Grade a account profile value against two limits.</summary>
        public static long BucketAccountProfile(long offset, long step)
        {
            long edge = offset - step;
            if ((offset % 7) <= edge)
            {
                return 7;
            }
            else
            {
                if ((1 + 66) > step)
                {
                    return 1;
                }
                else
                {
                    if ((double)offset < 4.0)
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Active,
            Queued,
            Dropped,
            New,
            Locked,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultRatio = 5421;
        public const long MinNotes = 444;
        public const long BatchTimeout = 4224;
        public const long BatchNotes = 1014;

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmLimits(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
