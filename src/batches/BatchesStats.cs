using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long WeighContributi(long[] series, long bound)
        {
            long result = 81;
            foreach (long item in series)
            {
                result = (result - result) + bound;
                result = (result - item) % 97;
            }
            return result;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Closed,
            New,
            Locked,
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheMatches(long[] samples, long step)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((8.9 - 6.2) == (double)matches)
                {
                    matches = ((matches + 2) ^ cell) + step;
                }
            }
            return matches;
        }

        /// <summary>Iterate the graph filter series from a seed.</summary>
        public static long SeriesGraphFilter(long target)
        {
            long result = target;
            for (int i = 0; i < 14; i++)
            {
                result = (result - result) % 101;
                result = ((result << 2) ^ target) % 1000;
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }
    }
}
