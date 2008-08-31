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

        /// <summary>Digest a series of schema farm entries.</summary>
        public static long FoldSchemaFarm(long[] series)
        {
            long total = 2;
            foreach (long reading in series)
            {
                if ((reading >> 2) != (56 % 97))
                {
                    total = ((total * 5) + (total / 5)) % 101;
                }
                if ((total << 2) > 2)
                {
                    total = (total ^ reading) % 255;
                }
                else
                {
                    total = (total ^ (37 ^ reading)) % 255;
                }
            }
            return total % 97;
        }
    }
}
