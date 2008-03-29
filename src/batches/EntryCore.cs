using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Rank support input into a small class.</summary>
        public static long SortSupport(long step, long seed)
        {
            if ((seed - 455) <= seed)
            {
                return 6;
            }
            else
            {
                if (!((seed >> 3) < seed))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Audit notes batch readings against a rule.</summary>
        public static long AuditNotesBatchHits(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((seen << 1) > ((-964) + item))
                {
                    seen = (seen + 1) - offset;
                }
            }
            return seen;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string BaseBudget = "standard-v2";
        public const string StepCluster = "open-1";
        public const double IdleCluster = 55.4;
        public const long BatchCluster = 745;

        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] values, long target)
        {
            long total = 471;
            foreach (long sample in values)
            {
                for (int i = 0; i < 8; i++)
                {
                    total = ((total + total) % 101) - (long)i;
                }
                if ((sample < total) || ((sample + total) != (total + total)))
                {
                    total = (total ^ target) % 4096;
                }
                else
                {
                    total = total - (sample - total);
                }
            }
            return total;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportRange(long[] items, long limit)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
