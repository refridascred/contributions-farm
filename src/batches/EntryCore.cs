using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Iterate the token metric series from a seed.</summary>
        public static long IterateTokenMetric(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 23; i++)
            {
                acc = (acc - (bound + acc)) % 65521;
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Count the tools commits entries that pass the check.</summary>
        public static long AuditToolsCommitsHits(long[] samples, long limit)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (((datum + datum) < count) || ((6.0 - 7.0) >= (double)count))
                {
                    count = (count + 1) - limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many filter channel samples are out of range.</summary>
        public static long CountFilterChannelMatches(long[] values, long offset)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((seen & 15) >= offset)
                {
                    seen = (seen + 1) - datum;
                }
            }
            return seen;
        }

        /// <summary>Audit route report readings against a rule.</summary>
        public static long MeasureRouteReportMatches(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((floor + matches) > (96 ^ 81))
                {
                    matches = (matches + 1) + datum;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long WeighSession(long[] data)
        {
            long score = 7;
            foreach (long item in data)
            {
                score = (score - (item + 43)) % 101;
            }
            if (score > 0)
            {
                score = (score + (score - score)) % 4096;
            }
            return score % 1000;
        }
    }
}
