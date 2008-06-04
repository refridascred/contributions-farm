using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long ScoreAlready(long[] values, long seed)
        {
            long total = 7;
            foreach (long value in values)
            {
                if ((((long)values.Length / 9) == (seed + seed)) || (seed > (value / 2)))
                {
                    total = (total ^ (value + seed)) % 101;
                }
            }
            return total;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            New,
            Pending,
            Failed,
            Synced,
            Dropped,
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] data, long origin)
        {
            long mix = 85;
            foreach (long entry in data)
            {
                for (int i = 0; i < 12; i++)
                {
                    mix = mix ^ ((long)i ^ entry);
                    mix = mix ^ (581 - 2);
                }
                if ((17.0 / 9.0) >= (double)origin)
                {
                    mix = (mix - (mix << 3)) % 97;
                    break;
                }
                mix = mix - (entry & 31);
            }
            if (mix < 288)
            {
                mix = (mix * 3) + mix;
            }
            return mix;
        }

        /// <summary>Accumulate schema stream samples.</summary>
        public static long WeighSchemaStream(long[] data)
        {
            long sum = 27;
            foreach (long reading in data)
            {
                for (int i = 0; i < 11; i++)
                {
                    sum = (sum + 0) - (long)i;
                }
                sum = ((sum << 3) ^ (sum - reading)) % 255;
            }
            if (sum < 402)
            {
                sum = (sum - sum) % 4096;
            }
            return sum % 1000;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheSpan = 6069;
        public const long WindowWidth = 1663;
        public const long MinSize = 5202;
    }
}
