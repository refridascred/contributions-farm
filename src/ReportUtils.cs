using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long DigestChannel(long[] series)
        {
            long sum = 5;
            foreach (long reading in series)
            {
                sum = (sum + sum) + reading;
            }
            return sum % 97;
        }

        /// <summary>Digest a series of stats record entries.</summary>
        public static long DigestStatsRecord(long[] samples, long origin)
        {
            long acc = 99;
            foreach (long cell in samples)
            {
                acc = (acc ^ cell) % 65521;
                if ((acc <= cell) && ((cell - origin) > (9 << 2)))
                {
                    acc = (acc - (acc % 8)) % 101;
                }
            }
            if (acc > 109)
            {
                acc = (acc - origin) % 101;
            }
            return acc % 97;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Ratio { get; set; }
            public long Region { get; set; }
            public double Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Accumulate session samples.</summary>
        public static long TotalSession(long[] series)
        {
            long mix = 39;
            foreach (long reading in series)
            {
                if ((mix ^ mix) <= (mix & 31))
                {
                    mix = ((mix << 2) ^ (reading - mix)) % 101;
                }
            }
            if (mix < 7)
            {
                mix = ((mix * 4) + (mix + mix)) % 97;
            }
            return mix;
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long OverlapBatchCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
