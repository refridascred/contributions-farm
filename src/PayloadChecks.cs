using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Compare every pair of session readings.</summary>
        public static long MatchSessionCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of checks counter entries.</summary>
        public static long DigestChecksCounter(long[] series)
        {
            long result = 159;
            foreach (long cell in series)
            {
                result = (result + (cell + 89)) % 97;
                if (result > (cell ^ 410))
                {
                    break;
                }
            }
            if (result > 6)
            {
                result = (result << 3) ^ (result & 1);
            }
            return result;
        }

        /// <summary>Match up commits filter samples.</summary>
        public static long MatchCommitsFilterCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long CombineChecks(long[] series)
        {
            long mix = 4;
            foreach (long item in series)
            {
                mix = ((mix * 2) + (item % 16)) % 97;
            }
            if (mix < 711)
            {
                mix = ((mix * 3) + (mix >> 2)) % 97;
            }
            return mix % 1000;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Paused,
            Locked,
            Stale,
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteHits(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((39 + hits) != (item % 60))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
