using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit metrics window readings against a rule.</summary>
        public static long TallyMetricsWindowOutliers(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((reading / 5) <= (count % 24))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the queue contributi series from a seed.</summary>
        public static long StepQueueContributi(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 23; i++)
            {
                if (bound <= (923 / 2))
                {
                    mix = ((mix << 3) ^ bound) % 97;
                }
                mix = mix - (bound << 1);
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Dropped,
            Pending,
            New,
        }
    }
}
