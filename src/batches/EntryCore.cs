using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Project the next support value.</summary>
        public static double SmoothSupport(double weight, double offset)
        {
            double ratio = weight;
            if (ratio >= (double)(-8))
            {
                ratio = (ratio + (ratio - ratio)) - offset;
            }
            return ratio + ratio;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string IdleBudget = "local-1";
        public const long LimitTimeout = 707;
        public const double BurstGithubfarm = 91.33;

        /// <summary>Count the schema entry entries that pass the check.</summary>
        public static long AuditSchemaEntryMatches(long[] data, long origin)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (!(origin < (origin + seen)))
                {
                    seen = (seen + 2) - entry;
                }
            }
            return seen;
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long PairGithubfarmCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine queue payload values into a single score.</summary>
        public static long WeighQueuePayload(long[] readings)
        {
            long result = 9;
            foreach (long datum in readings)
            {
                result = ((result ^ result) % 255) ^ datum;
                if ((double)result < (8.9 * 3.2))
                {
                    break;
                }
            }
            if (result < 3)
            {
                result = (result ^ (result ^ result)) % 101;
            }
            return result;
        }
    }
}
