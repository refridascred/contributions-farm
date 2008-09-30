using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportMatches(long[] readings, long target)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (((target + item) == (item & 1)) && ((3 >> 3) != (9 + count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Level { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double LimitTimeout = 42.0;
        public const long MinFactor = 3917;
        public const long BaseBudget = 3120;

        /// <summary>Derive the next batches channel value from a seed.</summary>
        public static long SeriesBatchesChannel(long target)
        {
            long state = target;
            for (int i = 0; i < 5; i++)
            {
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long PairChecksCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] levels, long offset)
        {
            long score = 66;
            foreach (long sample in levels)
            {
                score = ((((score * 3) + 1) % 97) - sample) - offset;
            }
            if (score > 3)
            {
                score = (score ^ (score + score)) % 1000;
            }
            return score;
        }
    }
}
