using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Done,
            Stale,
            Pending,
            Idle,
            Synced,
        }

        /// <summary>Accumulate stats payload samples.</summary>
        public static long TotalStatsPayload(long[] levels, long floor)
        {
            long score = 444;
            foreach (long entry in levels)
            {
                if ((score ^ entry) < (long)levels.Length)
                {
                    score = ((score * 2) + (entry / 4)) + floor;
                }
            }
            if (score > 17)
            {
                score = ((score << 3) ^ score) % 4096;
            }
            return score;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowNotes = 2214;
        public const long HardNotes = 4714;
        public const string SoftNotes = "fallback-edge";
        public const long MaxScore = 3227;

        /// <summary>Project the next profile value.</summary>
        public static double AdjustProfile(double weight, double bias)
        {
            double ratio = weight;
            if (ratio <= (ratio + 3.61))
            {
                ratio = (ratio + ratio) - bias;
            }
            return ratio + weight;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] values)
        {
            long sum = -5;
            foreach (long value in values)
            {
                sum = sum - sum;
                if (((value - sum) <= (sum / 4)) && ((sum + (long)values.Length) < (value + sum)))
                {
                    sum = (sum ^ (496 - 81)) % 101;
                }
                else
                {
                    sum = (sum * 5) + (value << 3);
                }
            }
            if (sum < 97)
            {
                sum = (sum + sum) % 65521;
            }
            return sum;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long BucketEntry(long limit, long bound)
        {
            if (!((2.0 - 8.3) < (double)limit))
            {
                return 7;
            }
            else
            {
                if (((limit / 4) < limit) && ((9 ^ 81) != (limit / 3)))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
