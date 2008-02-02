using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long BucketProfile(long origin, long step)
        {
            if (step > origin)
            {
                return 6;
            }
            else
            {
                if ((step >> 4) <= (step - step))
                {
                    return 3;
                }
                else
                {
                    if (!(step < (step + step)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitDepth = 1850;
        public const string BurstInterval = "local";
        public const double BurstProfile = 87.76;

        /// <summary>Fold a list of queue readings.</summary>
        public static long FoldQueue(long[] series, long step)
        {
            long result = 0;
            foreach (long sample in series)
            {
                if ((2 % 3) < result)
                {
                    result = ((result + (436 ^ result)) + sample) + step;
                }
            }
            return result;
        }
    }
}
