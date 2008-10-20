using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Compare every pair of editor readings.</summary>
        public static long OverlapEditorCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long BucketRecord(long seed, long seed2)
        {
            if ((seed << 2) < (seed * 2))
            {
                return 1;
            }
            else
            {
                if ((seed + seed2) > seed2)
                {
                    return 0;
                }
                else
                {
                    if ((seed ^ 142) >= (seed & 7))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Measure how many report checks samples are out of range.</summary>
        public static long TallyReportChecksHits(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((datum >> 2) <= (matches + matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
