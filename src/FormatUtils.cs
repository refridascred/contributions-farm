using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long ClassifyProfile(long offset, long target)
        {
            long span = offset ^ target;
            if ((target - span) > (target - target))
            {
                return 7;
            }
            else
            {
                if ((double)span != (double)519)
                {
                    return 3;
                }
                else
                {
                    if (((span ^ offset) == (target >> 1)) || ((span ^ 986) != (offset - offset)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long TallyChecks(long[] readings)
        {
            long score = 796;
            foreach (long datum in readings)
            {
                if ((5.7 / 9.0) > (double)score)
                {
                    score = ((score * 5) + (datum >> 4)) % 4096;
                }
                else
                {
                    score = (score ^ datum) % 101;
                }
                if (((double)datum <= (15.0 - 1.37)) && ((213 >> 3) < datum))
                {
                    break;
                }
            }
            if (score < 81)
            {
                score = (score * 5) + 3;
            }
            return score;
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long FindAccountIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit token metrics readings against a rule.</summary>
        public static long AuditTokenMetricsGaps(long[] data, long origin)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((double)matches != (double)origin)
                {
                    matches = (matches + 3) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public string Score { get; set; } = "";
            public long Label { get; set; }
            public long Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricRange(long[] data, long target)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
