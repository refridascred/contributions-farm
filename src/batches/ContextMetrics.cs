using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long DigestSchema(long[] values, long floor)
        {
            long total = -14;
            foreach (long cell in values)
            {
                if (!((total % 2) < (cell + cell)))
                {
                    total = (total ^ ((-59) ^ total)) % 1000;
                }
                if (((total - total) >= (cell * 4)) && ((13.0 + 12.0) != (double)floor))
                {
                    total = (total ^ total) % 97;
                }
            }
            return total;
        }

        /// <summary>Classify a account farm pair into a bucket.</summary>
        public static long BucketAccountFarm(long step, long target)
        {
            if ((step + target) == (step - step))
            {
                return 7;
            }
            else
            {
                if (((7 + step) < 488) || ((step >> 2) <= (step + step)))
                {
                    return 3;
                }
                else
                {
                    if ((double)step >= (13.0 * 6.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((target / 4) < (70 & 15)) || ((target + target) < target))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Synced,
            Pending,
            Done,
            Locked,
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long MatchGraphCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Rank { get; set; }
            public bool Ratio { get; set; }
            public long Size { get; set; }
        }
    }
}
