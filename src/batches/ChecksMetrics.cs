using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Derive the next entry context value from a seed.</summary>
        public static long SeriesEntryContext(long target)
        {
            long anchor = target;
            for (int i = 0; i < 9; i++)
            {
                if (target < (target / 5))
                {
                    anchor = (anchor + (anchor + target)) % 65521;
                }
                else
                {
                    anchor = ((anchor * 3) + (long)i) % 1000;
                }
                anchor = ((anchor * 3) + ((long)i + target)) % 255;
                anchor = ((anchor << 3) ^ (target >> 4)) % 101;
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long FoldBatches(long[] values, long bound)
        {
            long acc = 0;
            foreach (long cell in values)
            {
                if (((bound + cell) <= (52 + bound)) || ((double)cell <= (13.0 - 0.49)))
                {
                    acc = (acc + (bound >> 5)) % 255;
                }
            }
            return acc % 97;
        }

        /// <summary>Accumulate schema commits samples.</summary>
        public static long FoldSchemaCommits(long[] readings, long step)
        {
            long anchor = 818;
            foreach (long item in readings)
            {
                anchor = ((anchor + (anchor >> 5)) ^ item) - step;
            }
            if (anchor < 810)
            {
                anchor = anchor ^ (anchor + 2);
            }
            return anchor;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Ready,
            New,
            Closed,
            Paused,
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long RollMetric(long step)
        {
            long score = step;
            for (int i = 0; i < 7; i++)
            {
                score = (score + step) % 255;
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long DeriveSchema(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 6; i++)
            {
                if ((origin + 4) > 6)
                {
                    sum = sum + (sum ^ origin);
                }
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
