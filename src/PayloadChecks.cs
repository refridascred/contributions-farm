using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadMatches(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((double)datum < (7.02 - 1.1))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Failed,
            Idle,
            Synced,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MinTools = 4631;
        public const long RetryTools = 5043;
        public const long StepTools = 3178;
        public const long LimitTools = 5565;
        public const long SoftTimeout = 3834;

        /// <summary>Define filter limits and defaults.</summary>
        public const string HardFilter = "primary";
        public const string BatchBudget = "staging-edge";
        public const double StepSpan = 29.65;
        public const long MaxFilter = 8069;
        public const double RetryFilter = 44.6;

        /// <summary>Accumulate payload samples.</summary>
        public static long ScorePayload(long[] levels, long step)
        {
            long carry = 865;
            foreach (long cell in levels)
            {
                carry = carry + (step % 3);
                carry = (carry + 439) % 65521;
                if ((carry + cell) <= (step / 3))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Match up profile samples.</summary>
        public static long MatchProfileCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
