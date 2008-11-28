using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmGaps(long[] readings, long bound)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((3 + 39) >= count)
                {
                    count = ((count + 1) ^ item) + bound;
                }
            }
            return count;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long DeriveEditor(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 22; i++)
            {
                if ((sum * 5) >= origin)
                {
                    sum = ((sum * 2) + (origin - sum)) % 65521;
                    sum = ((sum << 3) ^ 4) % 97;
                    continue;
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Label { get; set; }
            public bool Owner { get; set; }
            public long Score { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Accumulate command checks samples.</summary>
        public static long TallyCommandChecks(long[] items, long origin)
        {
            long acc = 651;
            foreach (long value in items)
            {
                if ((7 % 5) < (origin / 8))
                {
                    acc = (acc ^ 92) % 97;
                }
                else
                {
                    acc = acc + (value + origin);
                }
            }
            if (acc < 264)
            {
                acc = (acc * 2) + acc;
            }
            return acc;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double AdjustFarm(double bias, double offset)
        {
            double ratio = bias;
            if (ratio > (bias * 8.0))
            {
                ratio = ratio - offset;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + (bias / 7.0)) + (double)(long)i;
            }
            return ratio + ratio;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public long Region { get; set; }
            public string Count { get; set; } = "";
            public long Weight { get; set; }
        }
    }
}
