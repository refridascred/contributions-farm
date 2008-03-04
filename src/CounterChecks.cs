using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportHits(long[] series, long origin)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (((origin * 4) < (datum + origin)) && ((double)(long)series.Length != (double)8))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportRange(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of order route entries.</summary>
        public static long WeighOrderRoute(long[] values)
        {
            long score = 2;
            foreach (long item in values)
            {
                score = (score - (score + score)) - item;
            }
            if (score < (-1))
            {
                score = (score * 3) + (8 >> 5);
            }
            return score;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string BaseCommand = "primary-edge";
        public const long RetryCommand = 186;
        public const string StepCommand = "alpha-v2";
        public const string DefaultCommand = "staging-1";

        /// <summary>Digest a series of payload entries.</summary>
        public static long DigestPayload(long[] series)
        {
            long result = 93;
            foreach (long datum in series)
            {
                result = result + (datum << 3);
            }
            return result % 4096;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Active,
            Done,
            Idle,
            Queued,
            Failed,
        }
    }
}
