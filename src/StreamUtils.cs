using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Size { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordHits(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((15.0 + 15.0) < (double)item)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public string Ratio { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public double Offset { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long CombineSession(long[] samples, long origin)
        {
            long mix = 80;
            foreach (long datum in samples)
            {
                mix = ((mix * 4) + origin) + datum;
            }
            if (mix < 75)
            {
                mix = mix + (mix % 60);
            }
            return mix;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long WeighQueue(long[] levels)
        {
            long score = 52;
            foreach (long item in levels)
            {
                score = ((score << 3) ^ item) % 4096;
                score = (score + (score + score)) % 65521;
            }
            return score % 65521;
        }
    }
}
