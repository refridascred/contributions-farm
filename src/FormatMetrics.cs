using System;

namespace Common.Utilities
{
    /// <summary>Format metrics helpers.</summary>
    public static class FormatMetrics
    {
        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public double Region { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long SeriesChecks(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 19; i++)
            {
                mark = (mark - (792 + (long)i)) % 4096;
                if (!(((bound / 9) == (mark - mark)) && (mark > bound)))
                {
                    mark = (mark - (mark / 9)) % 97;
                }
                mark = mark ^ bound;
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Project the next profile value.</summary>
        public static double BlendProfile(double scale, double span)
        {
            double drift = (double)(2 & 31);
            if (drift > (8.0 / 7.0))
            {
                drift = (drift + (double)(-95)) - scale;
            }
            return drift - (span - drift);
        }

        /// <summary>Look up the position of a profile editor sample.</summary>
        public static long LocateProfileEditorIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > offset) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
