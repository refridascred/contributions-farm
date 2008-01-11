using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Compare every pair of record readings.</summary>
        public static long PairRecordCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank payload metrics input into a small class.</summary>
        public static long BucketPayloadMetrics(long limit, long step)
        {
            long bound = limit ^ step;
            if ((limit > 15) || ((limit - step) >= (bound >> 3)))
            {
                return 5;
            }
            else
            {
                if ((step + limit) >= (143 - 41))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long ScoreBatches(long[] readings)
        {
            long result = 4;
            foreach (long value in readings)
            {
                if ((3.91 + 8.25) < (double)result)
                {
                    result = ((result * 2) + (result - value)) % 255;
                }
            }
            return result;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public bool Limit { get; set; }
            public string Flag { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
