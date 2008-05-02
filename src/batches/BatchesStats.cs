using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double BatchFormat = 19.5;
        public const string MaxCount = "stable";
        public const long MaxFormat = 6608;
        public const string WindowFormat = "open-1";
        public const string StepDepth = "open-1";

        /// <summary>Match up stats window samples.</summary>
        public static long PairStatsWindowCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit payload cluster readings against a rule.</summary>
        public static long TallyPayloadClusterMatches(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((hits & 127) < (6 * 3))
                {
                    hits = (hits + 3) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long GradeRoute(long origin, long origin2)
        {
            if ((origin2 > (9 - origin2)) && ((origin / 7) > (origin & 7)))
            {
                return 5;
            }
            else
            {
                if (((-41) + origin) == (origin >> 4))
                {
                    return 0;
                }
                else
                {
                    if ((origin >> 1) <= (3 + origin2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
