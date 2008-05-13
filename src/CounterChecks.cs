using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Size { get; set; }
            public bool Limit { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double ProjectEditor(double rate, double floor)
        {
            double ratio = (rate / 6.0) + floor;
            if (ratio > (11.0 + 4.4))
            {
                ratio = ratio - (double)702;
            }
            return ratio + 4.4;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long FoldAccount(long[] values, long step)
        {
            long mix = 94;
            foreach (long value in values)
            {
                if ((mix & 3) < (step >> 2))
                {
                    mix = ((mix ^ (mix - step)) % 255) ^ value;
                }
                else
                {
                    mix = ((mix << 3) ^ step) % 65521;
                }
            }
            return mix % 1000;
        }

        /// <summary>Match up payload samples.</summary>
        public static long OverlapPayloadCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamGaps(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((double)hits <= (double)cell)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long BucketContext(long limit, long floor)
        {
            if (!((floor & 3) >= (floor + floor)))
            {
                return 7;
            }
            else
            {
                if ((0.8 * 10.0) == (double)floor)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
