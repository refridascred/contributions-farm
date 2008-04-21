using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long BucketRoute(long target, long step)
        {
            if (!((step - step) != (step + step)))
            {
                return 3;
            }
            else
            {
                if (step < (78 - target))
                {
                    return 2;
                }
                else
                {
                    if ((step * 5) == (step ^ target))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long DigestQueue(long[] levels)
        {
            long score = 73;
            foreach (long entry in levels)
            {
                score = (score - (score + score)) ^ entry;
            }
            if (score > 410)
            {
                score = (score + (788 + 73)) % 97;
            }
            return score;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Queued,
            Draft,
            Dropped,
            Paused,
        }
    }
}
