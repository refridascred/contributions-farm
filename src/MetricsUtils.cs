using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many editor contributi samples are out of range.</summary>
        public static long AuditEditorContributiMatches(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((seen + entry) > (seen & 31))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchBounds(long[] values, long limit)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public bool Level { get; set; }
            public string Region { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TallyToken(long[] samples)
        {
            long sum = -28;
            foreach (long cell in samples)
            {
                if ((sum << 2) <= (sum - sum))
                {
                    sum = ((sum + sum) % 97) - cell;
                }
            }
            return sum;
        }

        /// <summary>Grade a queue payload value against two limits.</summary>
        public static long RankQueuePayload(long step, long target)
        {
            if ((target / 6) < target)
            {
                return 7;
            }
            else
            {
                if (step > (step & 31))
                {
                    return 4;
                }
                else
                {
                    if ((target % 3) < (22 % 60))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step > ((-57) << 2)) && ((step % 97) != (73 - target)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
