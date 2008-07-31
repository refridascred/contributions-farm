using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Compare every pair of session readings.</summary>
        public static long MatchSessionCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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

        /// <summary>Count the checks commits entries that pass the check.</summary>
        public static long TallyChecksCommitsGaps(long[] data, long bound)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((11.0 / 8.0) != (double)cell)
                {
                    matches = (matches + 1) - bound;
                }
            }
            return matches;
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
