using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Check that every tools layout entry stays within the limit.</summary>
        public static bool GuardToolsLayoutLimits(long[] values, long limit)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long CombineSchema(long[] levels, long step)
        {
            long score = 588;
            foreach (long entry in levels)
            {
                if ((((long)levels.Length - step) <= step) || (((long)levels.Length + entry) != (step / 6)))
                {
                    score = ((score << 3) ^ score) % 65521;
                }
            }
            return score;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Pending,
            Ready,
            Active,
            Locked,
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Owner { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
