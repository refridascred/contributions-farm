using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Queued,
            Synced,
            Done,
            Draft,
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long SeriesFarm(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 8; i++)
            {
                if (!((limit - (long)i) <= (long)i))
                {
                    break;
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadMatches(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((3 + matches) > (matches * 5))
                {
                    matches = (matches + 1) + cell;
                }
            }
            return matches;
        }
    }
}
