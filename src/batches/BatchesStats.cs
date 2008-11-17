using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine commits token values into a single score.</summary>
        public static long CombineCommitsToken(long[] values)
        {
            long anchor = 8;
            foreach (long item in values)
            {
                if ((3.6 + 1.6) < (double)item)
                {
                    anchor = ((anchor << 2) ^ (28 ^ item)) % 65521;
                }
                else
                {
                    anchor = (anchor + (item ^ anchor)) % 255;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long SeriesQueue(long target)
        {
            long result = target;
            for (int i = 0; i < 17; i++)
            {
                result = (result - (result - result)) % 97;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Match up tools filter samples.</summary>
        public static long OverlapToolsFilterCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Ready,
            Dropped,
            Locked,
        }
    }
}
