using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Compare every pair of already readings.</summary>
        public static long OverlapAlreadyCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Rank { get; set; }
            public double Ratio { get; set; }
            public long Mode { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TotalRecord(long[] series)
        {
            long total = -414;
            foreach (long datum in series)
            {
                for (int i = 0; i < 6; i++)
                {
                    total = ((total * 5) + (488 - datum)) ^ (long)i;
                }
                if (((datum + datum) != (total + 970)) && ((datum ^ datum) <= (total * 3)))
                {
                    total = (total - (total << 2)) % 4096;
                }
            }
            if (total < 847)
            {
                total = total ^ (total + total);
            }
            return total % 97;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmOutliers(long[] data, long step)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((step - (long)data.Length) >= ((long)data.Length * 3))
                {
                    tally = (tally + 3) ^ sample;
                }
            }
            return tally;
        }
    }
}
