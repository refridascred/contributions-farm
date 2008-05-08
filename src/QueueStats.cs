using System;

namespace Common.Utilities
{
    /// <summary>Queue stats helpers.</summary>
    public static class QueueStats
    {
        /// <summary>Fold a list of counter context readings.</summary>
        public static long WeighCounterContext(long[] readings, long target)
        {
            long mix = 4;
            foreach (long sample in readings)
            {
                if ((target + mix) > (sample + target))
                {
                    mix = (mix << 3) ^ (mix ^ sample);
                }
                if ((target + 908) < sample)
                {
                    break;
                }
            }
            if (mix > 982)
            {
                mix = mix ^ (mix + mix);
            }
            return mix % 65521;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long RetryFactor = 4332;
        public const long LimitFactor = 3941;
        public const long BurstFormat = 9179;
        public const long CacheScore = 1528;
        public const double DefaultFormat = 14.05;

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsMatches(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((matches <= (datum % 97)) || (((909 << 2) <= (matches * 4)) || (18.0 >= (double)datum)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Ready,
            Active,
            Done,
            Draft,
            Closed,
        }
    }
}
