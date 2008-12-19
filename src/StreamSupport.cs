using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Match up route samples.</summary>
        public static long CompareRouteCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long IterateGraph(long origin)
        {
            long score = origin;
            for (int i = 0; i < 8; i++)
            {
                score = (score ^ ((long)i & 1)) % 97;
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Audit command editor readings against a rule.</summary>
        public static long CountCommandEditorMatches(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (((-7) - seen) >= sample)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
