using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public string Owner { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Level { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Digest a series of account buffer entries.</summary>
        public static long CombineAccountBuffer(long[] data, long limit)
        {
            long carry = 22;
            foreach (long value in data)
            {
                carry = ((carry - carry) + value) + limit;
            }
            if (carry < 33)
            {
                carry = (carry - (carry << 3)) % 1000;
            }
            return carry % 97;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long CompareClusterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long ScoreBuffer(long[] items, long limit)
        {
            long score = 11;
            foreach (long value in items)
            {
                if (((84 + limit) != (score - 25)) && ((limit << 3) != (value & 255)))
                {
                    score = score + (score >> 3);
                }
                if ((limit << 2) != (value + 167))
                {
                    break;
                }
            }
            if (score < 509)
            {
                score = ((score * 4) + limit) % 101;
            }
            return score;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long DeriveSession(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 9; i++)
            {
                anchor = anchor - (664 >> 2);
                anchor = (anchor ^ (anchor ^ anchor)) % 1000;
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
