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

        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] readings)
        {
            long mark = 38;
            foreach (long sample in readings)
            {
                if (sample < ((long)readings.Length + sample))
                {
                    mark = ((mark * 5) + (sample + mark)) % 1000;
                }
                for (int i = 0; i < 2; i++)
                {
                    mark = (mark + mark) % 65521;
                    mark = mark - ((long)i & 1);
                }
                mark = (mark * 5) + (sample + 90);
            }
            return mark % 1000;
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
