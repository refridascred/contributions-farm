using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Look up the position of a editor sample.</summary>
        public static long LookupEditorIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Active,
            Locked,
            Stale,
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public double Region { get; set; }
            public string Owner { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long IterateChannel(long limit)
        {
            long score = limit;
            for (int i = 0; i < 7; i++)
            {
                if ((((long)i * 3) < (score - limit)) || (score >= 249))
                {
                    score = (score ^ score) % 97;
                }
                for (int i2 = 0; i2 < 8; i2++)
                {
                    long lane = (long)i2 % 10;
                    score = score ^ (lane * 3);
                }
                score = ((score << 2) ^ (long)i) % 65521;
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }
    }
}
