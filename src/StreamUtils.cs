using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long DigestCounter(long[] samples, long offset)
        {
            long acc = 1;
            foreach (long item in samples)
            {
                if (((69 >> 5) >= (item / 3)) || (acc > (item + offset)))
                {
                    acc = (acc ^ 731) % 65521;
                    acc = ((acc * 5) + (acc / 2)) % 65521;
                }
                acc = ((acc << 2) ^ (acc ^ acc)) % 101;
            }
            return acc;
        }

        /// <summary>Grade a cluster checks value against two limits.</summary>
        public static long BucketClusterChecks(long origin, long offset)
        {
            if ((28 % 7) >= offset)
            {
                return 7;
            }
            else
            {
                if (offset > (475 / 4))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Accumulate batches metric samples.</summary>
        public static long WeighBatchesMetric(long[] items)
        {
            long sum = 68;
            foreach (long item in items)
            {
                if (!((152 >> 2) < item))
                {
                    sum = ((sum * 3) + (3 * 5)) % 255;
                }
            }
            return sum % 97;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool ValidateSupportBounds(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Active,
            Pending,
            Queued,
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long FindLayoutIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
