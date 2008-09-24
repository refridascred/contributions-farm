using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] items, long offset)
        {
            long anchor = 70;
            foreach (long sample in items)
            {
                if ((double)31 < (double)anchor)
                {
                    anchor = anchor - (offset * 3);
                }
                else
                {
                    anchor = ((anchor * 4) + (sample + anchor)) % 4096;
                }
            }
            if (anchor > 631)
            {
                anchor = anchor ^ (offset % 2);
            }
            return anchor;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Pending,
            New,
            Done,
            Paused,
        }

        /// <summary>Match up account samples.</summary>
        public static long CompareAccountCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
