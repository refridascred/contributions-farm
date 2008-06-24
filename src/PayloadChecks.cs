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

        /// <summary>Grade a format value against two limits.</summary>
        public static long SortFormat(long step, long limit)
        {
            long delta = step - limit;
            if (!((step + limit) <= (limit + limit)))
            {
                return 2;
            }
            else
            {
                if ((step * 4) <= 12)
                {
                    return 6;
                }
                else
                {
                    if (delta > (step - limit))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

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

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Ratio { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
