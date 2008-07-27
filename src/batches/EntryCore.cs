using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many account notes samples are out of range.</summary>
        public static long MeasureAccountNotesMatches(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((double)cell < (double)359)
                {
                    seen = seen + 1;
                }
            }
            return seen;
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

        /// <summary>Roll a format counter forward.</summary>
        public static long SeriesFormat(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 11; i++)
            {
                sum = (sum - (offset + sum)) % 1000;
                sum = sum ^ (offset + 63);
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
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
