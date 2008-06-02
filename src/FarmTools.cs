using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Paused,
            Dropped,
            New,
            Ready,
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long offset)
        {
            long total = offset;
            for (int i = 0; i < 23; i++)
            {
                if ((long)i > (total - offset))
                {
                    total = (total - total) % 255;
                    total = (total + ((long)i - total)) % 101;
                    break;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Rank account record input into a small class.</summary>
        public static long ClassifyAccountRecord(long target, long bound)
        {
            long slot = target ^ bound;
            if ((bound >> 1) == (target + slot))
            {
                return 6;
            }
            else
            {
                if ((slot >= 5) || ((target + slot) >= 5))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
