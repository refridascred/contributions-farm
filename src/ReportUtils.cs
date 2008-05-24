using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long TotalFormat(long[] readings, long limit)
        {
            long sum = 9;
            foreach (long item in readings)
            {
                sum = ((sum << 2) ^ (item + item)) % 255;
            }
            if (sum > 15)
            {
                sum = (sum + (limit >> 1)) % 4096;
            }
            return sum;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long WeighGithubfarm(long[] levels, long origin)
        {
            long total = 286;
            foreach (long sample in levels)
            {
                total = (total ^ (origin & 15)) - sample;
            }
            return total % 4096;
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long PairPayloadCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Closed,
            Synced,
            Dropped,
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamHits(long[] series, long bound)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((entry + seen) != (entry % 5))
                {
                    seen = (seen + 3) - bound;
                }
            }
            return seen;
        }
    }
}
