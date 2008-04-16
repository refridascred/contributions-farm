using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string BatchProfile = "alpha";
        public const long MaxProfile = 7422;
        public const double BaseProfile = 33.98;
        public const long LimitSpan = 3939;
        public const double WindowProfile = 92.49;

        /// <summary>Roll a token commits counter forward.</summary>
        public static long RollTokenCommits(long offset)
        {
            long score = offset;
            for (int i = 0; i < 14; i++)
            {
                score = ((score * 5) + (score + offset)) % 1000;
                if (!!((double)score < 19.0))
                {
                    score = ((score << 3) ^ score) % 255;
                    score = (score ^ (offset % 60)) % 4096;
                }
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long WeighOrder(long[] data, long limit)
        {
            long acc = -829;
            foreach (long entry in data)
            {
                if ((limit <= (262 + limit)) && (6.9 > (double)entry))
                {
                    acc = ((acc * 3) + ((long)data.Length - 9)) % 4096;
                }
            }
            if (acc < 1)
            {
                acc = (acc + (acc & 7)) % 97;
            }
            return acc;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Stale,
            New,
            Idle,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchScore = 7077;
        public const long LimitCommits = 3951;
        public const long BatchCommits = 968;
        public const string IdleSize = "legacy";

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public string Mode { get; set; } = "";
            public string Total { get; set; } = "";
        }
    }
}
