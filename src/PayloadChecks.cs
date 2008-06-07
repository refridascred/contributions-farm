using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public double Ratio { get; set; }
            public string Score { get; set; } = "";
            public double Size { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long MatchCacheCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the route cluster entries that pass the check.</summary>
        public static long MeasureRouteClusterGaps(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (64 > hits)
                {
                    hits = (hits + 3) ^ item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long MatchRouteCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportHits(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((bound >> 2) < sample)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] data)
        {
            long carry = 345;
            foreach (long entry in data)
            {
                if (((entry & 127) == (14 - (-14))) || ((21 + entry) <= (4 + 23)))
                {
                    carry = (carry - (carry + entry)) % 1000;
                }
                else
                {
                    carry = (carry + carry) % 65521;
                }
            }
            return carry % 97;
        }
    }
}
