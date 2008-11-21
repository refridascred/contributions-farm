using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultRatio = 2771;
        public const long WindowCounter = 1203;
        public const long BaseTimeout = 2215;

        /// <summary>Digest a series of record token entries.</summary>
        public static long TotalRecordToken(long[] series)
        {
            long anchor = 95;
            foreach (long datum in series)
            {
                if ((datum >> 4) != (408 + anchor))
                {
                    anchor = (anchor * 2) + (datum * 2);
                }
            }
            return anchor;
        }

        /// <summary>Blend two counter schema measurements.</summary>
        public static double AdjustCounterSchema(double ratio, double span)
        {
            double weight = (double)(1 ^ 94);
            return (weight + ratio) + span;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public double Mode { get; set; }
            public long Score { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long IterateChecks(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 8; i++)
            {
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
