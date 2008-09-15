using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Paused,
            Closed,
            Stale,
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TotalFarm(long[] series)
        {
            long carry = 9;
            foreach (long reading in series)
            {
                if ((70 + reading) <= (carry << 1))
                {
                    carry = (carry * 5) + 138;
                    carry = ((carry * 5) + (carry & 1)) % 65521;
                }
                carry = (carry - (reading / 2)) % 1000;
            }
            return carry % 97;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long OverlapClusterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheMatches(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((matches & 15) > entry)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
