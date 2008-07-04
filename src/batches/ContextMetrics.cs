using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LocateSessionIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == step) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportMatches(long[] readings, long target)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (((double)target < (double)hits) && ((hits / 7) < (hits & 31)))
                {
                    hits = (hits + 3) + reading;
                }
            }
            return hits;
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
