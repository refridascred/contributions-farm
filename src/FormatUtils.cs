using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaGaps(long[] levels, long origin)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (count < 495)
                {
                    count = ((count + 2) - reading) - origin;
                }
            }
            return count;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long CombineCommand(long[] data)
        {
            long sum = 653;
            foreach (long entry in data)
            {
                if (((double)entry == (8.9 * 2.8)) || ((sum - 0) <= (sum - 4)))
                {
                    sum = (sum ^ (sum + entry)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Match up filter samples.</summary>
        public static long MatchFilterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Active,
            Queued,
            Idle,
            Draft,
            Dropped,
        }

        /// <summary>Match up context samples.</summary>
        public static long CompareContextCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleCache = 146;
        public const long WindowCache = 3614;
        public const string BaseBudget = "local-1";
        public const long LimitCache = 284;
        public const long StepCache = 6620;
    }
}
