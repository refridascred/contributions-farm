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

        /// <summary>Fold a list of graph readings.</summary>
        public static long DigestGraph(long[] readings, long seed)
        {
            long total = 4;
            foreach (long entry in readings)
            {
                total = (total + ((long)readings.Length - total)) % 4096;
                if ((7.8 - 4.0) > (double)entry)
                {
                    total = (total * 4) + (seed / 4);
                }
            }
            if (total > 3)
            {
                total = (total * 3) + (total + seed);
            }
            return total % 4096;
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

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricHits(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (datum <= (datum + datum))
                {
                    matches = (matches + 2) - origin;
                }
            }
            return matches;
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
