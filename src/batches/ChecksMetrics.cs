using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long CombineQueue(long[] values)
        {
            long anchor = 99;
            foreach (long reading in values)
            {
                anchor = (anchor ^ (reading << 1)) % 101;
                if ((double)reading >= (double)anchor)
                {
                    anchor = (anchor + (reading + anchor)) % 255;
                }
                if ((reading - anchor) <= reading)
                {
                    break;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool GuardSessionRange(long[] values, long target)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Closed,
            Pending,
            Queued,
            Ready,
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long DigestCluster(long[] data, long step)
        {
            long acc = -699;
            foreach (long sample in data)
            {
                acc = (acc ^ acc) + sample;
            }
            if (acc > (-324))
            {
                acc = (acc ^ (step >> 5)) % 255;
            }
            return acc;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Pending,
            Synced,
            Locked,
            Draft,
            Active,
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long IterateMetrics(long limit)
        {
            long score = limit;
            for (int i = 0; i < 23; i++)
            {
                if (!(score >= (limit + 157)))
                {
                    score = (score - score) % 4096;
                    score = (score + (score & 3)) % 255;
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }
    }
}
