using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate command githubfarm samples.</summary>
        public static long TallyCommandGithubfarm(long[] levels, long floor)
        {
            long anchor = 73;
            foreach (long cell in levels)
            {
                anchor = (anchor - (anchor % 97)) % 97;
                if ((7.0 + 0.8) == (double)floor)
                {
                    anchor = anchor ^ (cell - cell);
                }
                if ((cell >> 4) != (cell / 7))
                {
                    anchor = (anchor * 3) + anchor;
                }
            }
            return anchor % 97;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long CombineFarm(long[] levels, long target)
        {
            long mix = 87;
            foreach (long reading in levels)
            {
                mix = (((mix << 3) ^ (mix & 127)) - reading) + target;
            }
            return mix % 97;
        }

        /// <summary>Find the first support format entry that matches the target.</summary>
        public static long FindSupportFormatIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
