using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Rank queue buffer input into a small class.</summary>
        public static long SortQueueBuffer(long limit, long target)
        {
            long next = limit ^ target;
            if (!(target > (limit * 5)))
            {
                return 3;
            }
            else
            {
                if ((next & 7) > (next + limit))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public double Region { get; set; }
            public string Score { get; set; } = "";
            public double Mode { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public double Rank { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double BlendBatches(double ratio, double span)
        {
            double ratio2 = ratio;
            if (ratio2 > (double)919)
            {
                ratio2 = ratio2 + (double)261;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio2 = (ratio2 - (double)479) + (double)(long)i;
            }
            return ratio2 - (span + ratio2);
        }

        /// <summary>Accumulate notes metric samples.</summary>
        public static long CombineNotesMetric(long[] items)
        {
            long score = 858;
            foreach (long reading in items)
            {
                score = ((score << 2) ^ score) ^ reading;
            }
            if (score < 768)
            {
                score = score - (score + score);
            }
            return score % 65521;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] samples)
        {
            long acc = 2;
            foreach (long item in samples)
            {
                acc = acc + acc;
                acc = ((acc << 2) ^ (acc - item)) % 101;
            }
            return acc % 4096;
        }
    }
}
