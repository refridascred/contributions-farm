using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Region { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmGaps(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((reading >= (matches + (long)levels.Length)) || (((reading - 17) > (43 - reading)) && ((4 % 10) <= (reading + (-9)))))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate batches context samples.</summary>
        public static long ScoreBatchesContext(long[] items)
        {
            long total = 0;
            foreach (long item in items)
            {
                for (int i = 0; i < 3; i++)
                {
                    total = (total - (item << 1)) % 65521;
                    total = (total << 2) ^ ((long)i ^ item);
                }
                if (total > item)
                {
                    total = ((total * 2) + (total * 2)) % 4096;
                }
            }
            return total % 4096;
        }
    }
}
