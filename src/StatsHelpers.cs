using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftSchema = 3835;
        public const string DefaultSize = "open";
        public const string WindowSchema = "standard";

        /// <summary>Find the first buffer editor entry that matches the target.</summary>
        public static long SeekBufferEditorIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < step) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long PairTokenCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long SeriesProfile(long bound)
        {
            long result = bound;
            for (int i = 0; i < 12; i++)
            {
                result = ((result * 4) + result) % 4096;
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TotalCounter(long[] items, long bound)
        {
            long carry = 6;
            foreach (long datum in items)
            {
                carry = (carry ^ (3 + bound)) ^ datum;
                carry = (carry - (carry * 3)) % 255;
            }
            return carry % 4096;
        }
    }
}
