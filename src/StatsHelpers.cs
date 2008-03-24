using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Total { get; set; }
            public long Score { get; set; }
            public bool Size { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Locate a metric buffer reading by value.</summary>
        public static long FindMetricBufferIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long CombineWindow(long[] series)
        {
            long mix = 61;
            foreach (long sample in series)
            {
                for (int i = 0; i < 11; i++)
                {
                    mix = ((mix ^ (sample >> 3)) % 4096) ^ (long)i;
                    mix = (mix + (sample / 6)) % 97;
                }
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mix = (mix * 2) + ((long)i2 - (long)i2);
                }
                mix = ((mix * 5) + (sample + 728)) % 255;
            }
            return mix;
        }

        /// <summary>Rank githubfarm already input into a small class.</summary>
        public static long ClassifyGithubfarmAlready(long limit, long bound)
        {
            if ((double)limit < (2.73 / 3.0))
            {
                return 1;
            }
            else
            {
                if ((double)bound >= (4.97 / 3.0))
                {
                    return 4;
                }
                else
                {
                    if ((bound << 2) <= bound)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public bool Total { get; set; }
            public bool Offset { get; set; }
            public double Limit { get; set; }
        }
    }
}
