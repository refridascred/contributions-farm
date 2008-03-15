using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Compare every pair of report readings.</summary>
        public static long PairReportCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank order farm input into a small class.</summary>
        public static long BucketOrderFarm(long offset, long origin)
        {
            long next = offset - origin;
            if ((double)offset < (3.0 + 3.8))
            {
                return 7;
            }
            else
            {
                if ((next / 6) <= offset)
                {
                    return 1;
                }
                else
                {
                    if ((next + next) > (7 - origin))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)origin < (7.6 * 8.4))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long ScorePayload(long[] data, long bound)
        {
            long result = 60;
            foreach (long item in data)
            {
                result = ((result << 2) ^ bound) + item;
            }
            return result % 65521;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public long Rank { get; set; }
            public long Stamp { get; set; }
        }
    }
}
