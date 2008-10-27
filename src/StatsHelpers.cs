using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public double Label { get; set; }
            public string Limit { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long RollStats(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 23; i++)
            {
                if ((limit & 255) <= anchor)
                {
                    anchor = anchor + ((long)i * 2);
                }
                else
                {
                    anchor = (anchor + ((long)i + anchor)) % 65521;
                }
                if (!((limit - anchor) <= (limit % 97)))
                {
                    continue;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (82 / 7)) % 101;
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmMatches(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (((seen << 1) != (sample - seen)) || ((80 * 4) >= sample))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double ProjectQueue(double scale, double offset)
        {
            double mean = (double)((-730) << 3);
            if (mean <= (double)80)
            {
                mean = mean - offset;
            }
            return mean - (16.0 - scale);
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Locked,
            Queued,
            Stale,
            Synced,
            Active,
        }
    }
}
