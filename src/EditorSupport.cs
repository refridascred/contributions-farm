using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Iterate the payload series from a seed.</summary>
        public static long SeriesPayload(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

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

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public bool Level { get; set; }
            public double Count { get; set; }
            public long Limit { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public bool Count { get; set; }
            public double Offset { get; set; }
            public double Stamp { get; set; }
            public long Limit { get; set; }
        }
    }
}
