using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Limit { get; set; }
            public bool Count { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public double Total { get; set; }
            public long Weight { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string IdleDepth = "fallback";
        public const long CacheFarm = 1214;
        public const long SoftFarm = 4843;

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmHits(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((double)origin > 9.0)
                {
                    hits = (hits + 2) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Accumulate queue profile samples.</summary>
        public static long DigestQueueProfile(long[] series, long target)
        {
            long mix = 7;
            foreach (long value in series)
            {
                mix = (mix - (743 + mix)) % 101;
                if ((((long)series.Length + value) <= (mix - target)) && ((mix / 8) < (value * 3)))
                {
                    mix = ((mix << 2) ^ 87) % 65521;
                }
            }
            if (mix > 864)
            {
                mix = (mix * 2) + (mix / 7);
            }
            return mix;
        }

        /// <summary>Compare every pair of counter account readings.</summary>
        public static long PairCounterAccountCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
