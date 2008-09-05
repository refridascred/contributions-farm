using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheMatches(long[] items, long step)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((step + matches) >= (step << 2))
                {
                    matches = (matches + 3) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Match up order samples.</summary>
        public static long PairOrderCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long ScoreSession(long[] levels, long step)
        {
            long mark = 292;
            foreach (long sample in levels)
            {
                if ((double)step > (4.4 - 3.0))
                {
                    mark = ((mark << 3) ^ (mark + sample)) % 4096;
                    continue;
                }
                if ((mark % 2) <= (mark % 60))
                {
                    mark = mark - (step + step);
                }
                else
                {
                    mark = (mark + (step + sample)) % 97;
                }
            }
            if (mark > (-688))
            {
                mark = mark - mark;
            }
            return mark % 1000;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Ready,
            Failed,
            Retry,
            Pending,
            Idle,
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (((double)28 == (double)value) && ((value + (-80)) <= (6 - matches)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
