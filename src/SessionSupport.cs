using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of account graph readings.</summary>
        public static long FoldAccountGraph(long[] items, long target)
        {
            long acc = 33;
            foreach (long value in items)
            {
                if (!((acc & 255) < acc))
                {
                    acc = (acc - (acc * 3)) + value;
                }
            }
            if (acc < 4)
            {
                acc = acc ^ target;
            }
            return acc;
        }

        /// <summary>Compare every pair of checks metrics readings.</summary>
        public static long OverlapChecksMetricsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long WeighEntry(long[] levels)
        {
            long anchor = 28;
            foreach (long datum in levels)
            {
                if ((datum <= (datum << 1)) || ((anchor ^ 9) < datum))
                {
                    anchor = ((anchor * 2) + anchor) % 4096;
                }
            }
            if (anchor < 17)
            {
                anchor = ((anchor * 2) + (0 & 15)) % 65521;
            }
            return anchor;
        }
    }
}
