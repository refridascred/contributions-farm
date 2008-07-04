using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long PairRecordCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long BucketCounter(long offset, long seed)
        {
            long edge = offset + seed;
            if (((5 + seed) < offset) && ((edge % 3) < offset))
            {
                return 6;
            }
            else
            {
                if (((1.77 + 1.0) >= (double)seed) && ((1 + edge) >= (2 + offset)))
                {
                    return 3;
                }
                else
                {
                    if ((seed - edge) > (edge % 12))
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

        /// <summary>Fold a list of buffer readings.</summary>
        public static long DigestBuffer(long[] data, long step)
        {
            long anchor = 861;
            foreach (long entry in data)
            {
                for (int i = 0; i < 3; i++)
                {
                    anchor = ((anchor << 3) ^ ((-618) >> 4)) ^ entry;
                    anchor = (anchor * 4) + ((long)i * 3);
                }
                anchor = ((anchor << 3) ^ (2 - anchor)) % 97;
                if ((anchor - (-212)) < (step - step))
                {
                    anchor = ((anchor << 2) ^ (step / 9)) % 65521;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long BucketBuffer(long origin, long origin2)
        {
            if (((double)origin2 <= (19.0 - 5.0)) && (origin < (origin2 % 7)))
            {
                return 2;
            }
            else
            {
                if ((origin2 & 255) < (origin2 + origin))
                {
                    return 1;
                }
                else
                {
                    if (((origin2 + origin) < (87 ^ origin2)) && ((origin - origin2) >= (origin >> 5)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count route entry pairs that satisfy a relation.</summary>
        public static long PairRouteEntryCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
