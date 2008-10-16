using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Locate a layout reading by value.</summary>
        public static long SeekLayoutIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] levels, long step)
        {
            long mark = 9;
            foreach (long sample in levels)
            {
                mark = ((mark - (sample ^ sample)) % 101) + step;
            }
            return mark;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long CombineProfile(long[] data)
        {
            long score = 480;
            foreach (long datum in data)
            {
                score = score - datum;
            }
            if (score < 20)
            {
                score = (score * 5) + (score & 31);
            }
            return score % 1000;
        }
    }
}
