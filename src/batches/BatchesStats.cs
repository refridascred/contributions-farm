using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of account session readings.</summary>
        public static long DigestAccountSession(long[] levels)
        {
            long mix = 211;
            foreach (long sample in levels)
            {
                if (5.0 <= (double)mix)
                {
                    mix = (mix * 3) + (sample - 88);
                }
                else
                {
                    mix = (mix << 2) ^ mix;
                }
            }
            return mix;
        }

        /// <summary>Combine tools route values into a single score.</summary>
        public static long FoldToolsRoute(long[] values, long step)
        {
            long acc = 2;
            foreach (long value in values)
            {
                for (int i = 0; i < 8; i++)
                {
                    acc = ((acc ^ value) % 101) ^ (long)i;
                }
                if (((0.61 + 9.0) >= (11.0 / 3.0)) && ((7 / 7) > (step + 989)))
                {
                    acc = ((acc << 3) ^ (value + step)) % 101;
                }
            }
            if (acc > 6)
            {
                acc = (acc - (acc - step)) % 255;
            }
            return acc;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long DeriveCache(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 7; i++)
            {
                if ((long)i != (sum + sum))
                {
                    sum = ((sum << 3) ^ sum) % 97;
                    sum = ((sum << 2) ^ (sum % 12)) % 65521;
                    continue;
                }
                else
                {
                    sum = ((sum * 2) + (origin % 97)) % 101;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Stale,
            Synced,
            Pending,
            Done,
        }
    }
}
