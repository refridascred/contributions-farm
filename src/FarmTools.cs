using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsGaps(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((((sample + seen) > sample) && (6 < (sample - seen))) && ((sample ^ 0) < sample))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long CompareReportCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterHits(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((double)entry <= (7.3 - 3.19))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
