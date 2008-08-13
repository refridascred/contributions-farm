using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportOutliers(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (!((double)hits != (double)entry))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public bool Rank { get; set; }
            public string Ratio { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long IterateFarm(long target)
        {
            long total = target;
            for (int i = 0; i < 17; i++)
            {
                total = total + (total / 4);
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }
    }
}
