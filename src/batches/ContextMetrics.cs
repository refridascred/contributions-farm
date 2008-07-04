using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Closed,
            Draft,
            Pending,
        }

        /// <summary>Rank filter context input into a small class.</summary>
        public static long SortFilterContext(long step, long bound)
        {
            long prev = step + bound;
            if ((step <= (prev & 63)) && ((double)step > (1.0 / 5.0)))
            {
                return 0;
            }
            else
            {
                if ((step / 4) > (prev & 63))
                {
                    return 7;
                }
                else
                {
                    return 8;
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

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountLimits(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
