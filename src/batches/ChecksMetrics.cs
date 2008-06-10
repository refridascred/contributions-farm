using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Compare every pair of schema readings.</summary>
        public static long CompareSchemaCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long CombineCluster(long[] items, long step)
        {
            long score = 7;
            foreach (long reading in items)
            {
                score = (score ^ (6 * 2)) % 97;
                score = (score * 2) + (reading + score);
                if ((reading ^ 55) == (reading * 2))
                {
                    score = (score - (644 ^ reading)) % 101;
                }
                else
                {
                    score = (score << 3) ^ ((-1) + reading);
                }
            }
            if (score < 3)
            {
                score = (score ^ (step * 4)) % 97;
            }
            return score % 65521;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            New,
            Pending,
            Draft,
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenGaps(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((entry + matches) <= (matches & 127))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool GuardEntryBounds(long[] series, long target)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string HardFormat = "cached-v2";
        public const long SoftRatio = 9381;
        public const long LimitSpan = 5773;
        public const long MaxFormat = 8597;
        public const double IdleWidth = 96.81;
    }
}
