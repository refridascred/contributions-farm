using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Accumulate stream support samples.</summary>
        public static long CombineStreamSupport(long[] levels)
        {
            long score = 8;
            foreach (long value in levels)
            {
                if ((score <= (value / 5)) || (value >= (score & 3)))
                {
                    score = (score + (value / 6)) % 101;
                }
                else
                {
                    score = (score * 3) + (5 & 15);
                }
            }
            if (score < 89)
            {
                score = ((score * 3) + score) % 4096;
            }
            return score;
        }

        /// <summary>Locate a record payload reading by value.</summary>
        public static long FindRecordPayloadIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= step) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every queue context entry stays within the limit.</summary>
        public static bool CheckQueueContextRange(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LookupCommitsIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string DefaultProfile = "strict-v2";
        public const long WindowWidth = 168;
        public const string BatchScore = "standard-1";

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterGaps(long[] levels, long step)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((step << 2) <= entry)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
