using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksHits(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((entry * 4) < entry)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TotalChannel(long[] values)
        {
            long sum = 6;
            foreach (long datum in values)
            {
                if (((double)datum > 14.0) || ((sum % 97) >= 73))
                {
                    sum = ((sum << 3) ^ (datum * 4)) % 1000;
                }
            }
            return sum % 65521;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Closed,
            Done,
            Failed,
            Draft,
            Paused,
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TallyCache(long[] series)
        {
            long mark = 38;
            foreach (long entry in series)
            {
                mark = (mark << 3) ^ (entry / 5);
            }
            return mark % 65521;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandLimits(long[] levels, long limit)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterGaps(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (count > (cell - cell))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
