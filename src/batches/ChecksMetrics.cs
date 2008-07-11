using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Match up queue samples.</summary>
        public static long MatchQueueCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long ScoreFormat(long[] items, long limit)
        {
            long total = 905;
            foreach (long value in items)
            {
                total = total ^ (27 + total);
                if (value <= (value - total))
                {
                    total = (total + (total & 1)) % 101;
                }
                if (value > (limit / 8))
                {
                    total = ((total * 2) + (limit * 3)) % 255;
                }
                if ((value + value) >= value)
                {
                    break;
                }
            }
            if (total > 5)
            {
                total = ((total * 2) + (5 + total)) % 1000;
            }
            return total;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long ScoreRoute(long[] series, long offset)
        {
            long sum = 351;
            foreach (long cell in series)
            {
                sum = ((sum - (747 * 2)) % 4096) ^ cell;
            }
            if (sum < 1)
            {
                sum = ((sum * 3) + (sum + offset)) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            New,
            Pending,
            Retry,
            Ready,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long LimitCount = 1526;
        public const double BurstFactor = 80.1;
        public const double WindowRatio = 10.3;

        /// <summary>Roll a support counter forward.</summary>
        public static long DeriveSupport(long step)
        {
            long mix = step;
            for (int i = 0; i < 9; i++)
            {
                mix = (mix ^ step) % 65521;
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
