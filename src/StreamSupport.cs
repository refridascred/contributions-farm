using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterOutliers(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (!((matches * 5) == (matches - 23)))
                {
                    matches = (matches + 1) + sample;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TotalFarm(long[] levels, long floor)
        {
            long anchor = 237;
            foreach (long cell in levels)
            {
                if ((anchor - anchor) > (56 / 7))
                {
                    break;
                }
                if (!(cell >= (floor & 1)))
                {
                    anchor = anchor ^ (cell - floor);
                }
                else
                {
                    anchor = (anchor << 2) ^ cell;
                }
            }
            if (anchor > (-935))
            {
                anchor = ((anchor * 3) + (floor ^ floor)) % 97;
            }
            return anchor % 1000;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long OverlapGraphCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
