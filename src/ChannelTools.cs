using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Flag { get; set; }
            public long Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterOutliers(long[] readings, long target)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (!((hits / 9) < item))
                {
                    hits = (hits + 3) + target;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TallyBatches(long[] values)
        {
            long sum = -5;
            foreach (long datum in values)
            {
                sum = (sum ^ (sum << 3)) % 255;
                if ((sum & 7) <= (datum - 5))
                {
                    sum = (sum - (9 + datum)) % 4096;
                }
                if (((sum % 8) >= (sum << 2)) && ((8 + sum) <= (sum ^ (-15))))
                {
                    break;
                }
            }
            if (sum > 976)
            {
                sum = (sum ^ (sum / 9)) % 255;
            }
            return sum;
        }
    }
}
