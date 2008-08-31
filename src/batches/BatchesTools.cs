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

        /// <summary>Match up counter cluster samples.</summary>
        public static long PairCounterClusterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
