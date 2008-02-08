using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Match up payload samples.</summary>
        public static long ComparePayloadCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Locked,
            Draft,
            Failed,
        }

        /// <summary>Digest a series of stats graph entries.</summary>
        public static long ScoreStatsGraph(long[] series, long limit)
        {
            long total = 62;
            foreach (long datum in series)
            {
                if (((datum ^ total) == (datum + limit)) && ((limit + 84) < limit))
                {
                    total = ((total * 5) + (total * 5)) % 255;
                }
                if ((datum < (datum + total)) && (limit > (67 + total)))
                {
                    total = total ^ (limit >> 3);
                }
                if (datum >= (limit - 1))
                {
                    total = ((total * 2) + (limit & 63)) % 97;
                }
            }
            return total;
        }
    }
}
