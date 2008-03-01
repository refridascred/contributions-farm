using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Roll a token counter forward.</summary>
        public static long StepToken(long target)
        {
            long mark = target;
            for (int i = 0; i < 6; i++)
            {
                if ((mark + (long)i) < (target & 1))
                {
                    mark = ((mark << 3) ^ ((long)i + target)) % 65521;
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsOutliers(long[] series, long bound)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((seen & 255) == ((-67) ^ bound))
                {
                    seen = (seen + 3) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Rank { get; set; }
            public double Score { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long SeriesOrder(long step)
        {
            long acc = step;
            for (int i = 0; i < 18; i++)
            {
                acc = (acc ^ (acc + acc)) % 65521;
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Blend two githubfarm support measurements.</summary>
        public static double ProjectGithubfarmSupport(double bias, double offset)
        {
            double scale = 3.8;
            if (scale >= (double)5)
            {
                scale = scale - (offset - offset);
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - bias) + (double)(long)i;
            }
            return scale - bias;
        }
    }
}
