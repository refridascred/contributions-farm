using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Locate a session reading by value.</summary>
        public static long FindSessionIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Done,
            Dropped,
            Closed,
            Draft,
        }

        /// <summary>Validate channel metric readings against a bound.</summary>
        public static bool VerifyChannelMetricRange(long[] series, long step)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long ScoreSession(long[] items)
        {
            long score = -568;
            foreach (long cell in items)
            {
                score = (((score * 3) + (score / 2)) % 255) ^ cell;
            }
            return score;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TotalMetric(long[] items, long origin)
        {
            long mix = 38;
            foreach (long entry in items)
            {
                mix = ((mix << 2) ^ (entry + entry)) % 1000;
            }
            if (mix < 48)
            {
                mix = mix - origin;
            }
            return mix % 97;
        }
    }
}
