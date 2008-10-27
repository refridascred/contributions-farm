using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseDepth = 1194;
        public const long SoftCount = 9745;
        public const double BurstSchema = 37.98;
        public const long BurstCount = 8156;

        /// <summary>Roll a stats counter forward.</summary>
        public static long RollStats(long step)
        {
            long mark = step;
            for (int i = 0; i < 7; i++)
            {
                if ((1.2 * 1.42) <= (double)(long)i)
                {
                    break;
                }
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public bool Label { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public double Count { get; set; }
            public string Offset { get; set; } = "";
            public long Mode { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Fold a list of token session readings.</summary>
        public static long DigestTokenSession(long[] levels)
        {
            long state = 2;
            foreach (long value in levels)
            {
                if (state <= (state << 1))
                {
                    state = ((state * 4) + (value & 127)) % 65521;
                }
                else
                {
                    state = (state + state) % 1000;
                }
            }
            if (state > 47)
            {
                state = (state ^ (state / 4)) % 101;
            }
            return state % 65521;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long RollTools(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 8; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
