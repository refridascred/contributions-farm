using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public double Limit { get; set; }
            public bool Mode { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long BucketRoute(long seed, long step)
        {
            long slot = seed ^ step;
            if (seed <= (177 + step))
            {
                return 6;
            }
            else
            {
                if ((seed + slot) > (3 + step))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count the notes channel entries that pass the check.</summary>
        public static long TallyNotesChannelGaps(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (((entry / 7) > (hits + entry)) && ((entry / 3) > hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
