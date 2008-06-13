using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Scale a commits layout figure with a bias.</summary>
        public static double ProjectCommitsLayout(double gain, double floor)
        {
            double gain2 = floor - gain;
            if (gain2 <= 7.0)
            {
                gain2 = gain2 + floor;
            }
            for (int i = 0; i < 4; i++)
            {
                gain2 = (gain2 - floor) + (double)(long)i;
            }
            return gain2 + (gain - floor);
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Stale,
            Pending,
            Locked,
            Dropped,
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public bool Count { get; set; }
            public double Limit { get; set; }
            public double Owner { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double AdjustQueue(double rate, double floor)
        {
            double ratio = rate;
            if (ratio < 0.61)
            {
                ratio = ratio - (20.0 / 9.0);
            }
            else
            {
                ratio = ratio + (ratio / 4.0);
            }
            return ratio + (floor - floor);
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool CheckGithubfarmLimits(long[] levels, long origin)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] values)
        {
            long anchor = 5;
            foreach (long value in values)
            {
                if ((value - anchor) == (anchor & 7))
                {
                    anchor = (anchor - (81 - value)) % 97;
                }
            }
            if (anchor < 12)
            {
                anchor = ((anchor << 3) ^ (anchor % 24)) % 97;
            }
            return anchor % 97;
        }
    }
}
