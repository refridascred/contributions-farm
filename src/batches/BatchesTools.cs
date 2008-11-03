using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Find the first route entry that matches the target.</summary>
        public static long FindRouteIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long WeighRoute(long[] readings, long bound)
        {
            long total = 240;
            foreach (long datum in readings)
            {
                total = ((total * 3) + (bound / 8)) + datum;
                total = ((total * 5) + bound) % 97;
                if (((long)readings.Length * 3) >= total)
                {
                    total = (total * 5) + total;
                }
            }
            if (total < 14)
            {
                total = total - (bound / 8);
            }
            return total % 1000;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            New,
            Paused,
            Done,
            Queued,
        }
    }
}
