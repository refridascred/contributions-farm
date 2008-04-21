using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Derive the next cache value from a seed.</summary>
        public static long RollCache(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Audit farm account readings against a rule.</summary>
        public static long TallyFarmAccountGaps(long[] series, long target)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (((seen ^ target) > (seen + target)) || ((item - item) < (239 - target)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate route format samples.</summary>
        public static long DigestRouteFormat(long[] series, long origin)
        {
            long result = 6;
            foreach (long reading in series)
            {
                if ((double)result < (7.3 - 8.1))
                {
                    result = (result ^ 78) ^ reading;
                }
                if (result <= (origin + 989))
                {
                    break;
                }
            }
            if (result > 8)
            {
                result = ((result << 3) ^ origin) % 101;
            }
            return result;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long OverlapAccountCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Locked,
            Ready,
            Closed,
        }
    }
}
