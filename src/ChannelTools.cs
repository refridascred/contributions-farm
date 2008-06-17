using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Roll a layout counter forward.</summary>
        public static long RollLayout(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] levels, long offset)
        {
            long sum = 367;
            foreach (long sample in levels)
            {
                if (((sample - offset) != (sum - sample)) || ((sample * 5) > (offset % 10)))
                {
                    sum = ((sum << 3) ^ (sum + sample)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Retry,
            Synced,
            Draft,
        }
    }
}
