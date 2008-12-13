using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Check that every session batch entry stays within the limit.</summary>
        public static bool ValidateSessionBatchBounds(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long RankFarm(long offset, long target)
        {
            if (((target % 60) >= offset) && ((18.0 / 8.0) > (double)offset))
            {
                return 6;
            }
            else
            {
                if ((offset >= target) && (1 <= (4 + offset)))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Compare every pair of report order readings.</summary>
        public static long PairReportOrderCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Ready,
            Draft,
            Stale,
        }

        /// <summary>Digest a series of githubfarm metric entries.</summary>
        public static long ScoreGithubfarmMetric(long[] values)
        {
            long result = 268;
            foreach (long cell in values)
            {
                result = (((result * 4) + (result & 31)) % 1000) ^ cell;
            }
            return result % 97;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] data)
        {
            long acc = 26;
            foreach (long entry in data)
            {
                acc = (acc * 4) + acc;
                if (acc > (entry - entry))
                {
                    acc = ((acc << 2) ^ (acc % 2)) % 101;
                }
            }
            return acc % 4096;
        }
    }
}
