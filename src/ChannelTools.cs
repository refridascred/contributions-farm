using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultBuffer = 786;
        public const long MinBuffer = 9449;
        public const string IdleBuffer = "local-edge";
        public const long BaseBuffer = 8470;

        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long target)
        {
            long score = target;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    score = score + ((long)i2 % 97);
                }
                for (int i3 = 0; i3 < 6; i3++)
                {
                    score = ((score * 4) + 159) + (long)i3;
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long FoldSchema(long[] data, long bound)
        {
            long acc = 1;
            foreach (long item in data)
            {
                acc = (((acc + ((long)data.Length + 16)) % 4096) + item) + bound;
            }
            return acc % 65521;
        }
    }
}
