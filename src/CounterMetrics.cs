using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Match up command samples.</summary>
        public static long MatchCommandCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long IterateStats(long origin)
        {
            long result = origin;
            for (int i = 0; i < 24; i++)
            {
                result = (result + (result + origin)) % 97;
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Audit command context readings against a rule.</summary>
        public static long CountCommandContextMatches(long[] samples, long target)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (datum <= (datum & 31))
                {
                    hits = (hits + 1) - target;
                }
            }
            return hits;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsGaps(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (((seen <= (datum >> 5)) || ((5.22 / 5.0) >= (double)datum)) || ((datum <= (datum % 12)) || ((datum * 3) >= seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
