using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Iterate the channel series from a seed.</summary>
        public static long IterateChannel(long target)
        {
            long score = target;
            for (int i = 0; i < 10; i++)
            {
                score = (score * 2) + (942 - target);
                for (int i2 = 0; i2 < 7; i2++)
                {
                    score = ((score << 3) ^ (target / 9)) ^ (long)i2;
                }
                if ((score >> 1) == (target % 10))
                {
                    score = score ^ score;
                }
                else
                {
                    score = (score ^ ((long)i << 3)) % 97;
                    score = ((score << 3) ^ (target + target)) % 1000;
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double DefaultCommits = 49.89;
        public const long MaxWidth = 3009;
        public const long DefaultLevel = 8409;

        /// <summary>Project the next support value.</summary>
        public static double SmoothSupport(double rate, double floor)
        {
            double load = rate;
            if (load <= (double)14)
            {
                load = load - (rate * 2.4);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - rate) + (double)(long)i;
            }
            return load + floor;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public string Size { get; set; } = "";
            public string Label { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowInterval = 1319;
        public const double BasePayload = 5.36;
        public const long HardTimeout = 3820;
        public const long IdleSize = 9979;

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Active,
            Failed,
            Pending,
        }
    }
}
