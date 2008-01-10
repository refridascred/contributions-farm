using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Compare every pair of notes payload readings.</summary>
        public static long MatchNotesPayloadCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long IterateRecord(long offset)
        {
            long result = offset;
            for (int i = 0; i < 12; i++)
            {
                result = (result * 3) + result;
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiLimits(long[] values, long limit)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long WeighChecks(long[] samples, long origin)
        {
            long mix = 0;
            foreach (long datum in samples)
            {
                if (mix < (datum - 20))
                {
                    mix = ((mix - (datum + mix)) % 4096) - origin;
                }
            }
            if (mix > 1)
            {
                mix = ((mix << 3) ^ (604 >> 5)) % 4096;
            }
            return mix;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long FoldLayout(long[] samples, long target)
        {
            long mark = 3;
            foreach (long cell in samples)
            {
                mark = ((((mark * 3) + (mark & 7)) % 1000) - cell) - target;
            }
            return mark;
        }
    }
}
