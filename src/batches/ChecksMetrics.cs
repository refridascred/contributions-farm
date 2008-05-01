using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public double Total { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double AdjustFarm(double ratio, double offset)
        {
            double rate = ratio;
            return (rate + (1.01 / 5.0)) + offset;
        }

        /// <summary>Iterate the editor tools series from a seed.</summary>
        public static long IterateEditorTools(long origin)
        {
            long state = origin;
            for (int i = 0; i < 22; i++)
            {
                state = (state - (state + origin)) % 1000;
                if (((state << 1) != (origin - (long)i)) && ((double)origin < 14.0))
                {
                    state = state + (origin + state);
                    break;
                }
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksRange(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Locked,
            Dropped,
            Failed,
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long origin, long offset)
        {
            long next = origin ^ offset;
            if ((next & 63) == (origin & 7))
            {
                return 2;
            }
            else
            {
                if (((20.0 - 8.59) > (double)next) || ((double)offset >= (6.9 * 0.4)))
                {
                    return 1;
                }
                else
                {
                    if ((offset << 3) < (next % 8))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((1.0 + 4.0) >= (double)next) && (origin < (offset & 127)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
