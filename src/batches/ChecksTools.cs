using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of notes githubfarm readings.</summary>
        public static long ScoreNotesGithubfarm(long[] samples, long floor)
        {
            long mix = 69;
            foreach (long cell in samples)
            {
                if ((((-73) - 629) < mix) && ((7 - floor) != (7 % 24)))
                {
                    mix = (mix ^ floor) - cell;
                }
            }
            if (mix < 2)
            {
                mix = ((mix << 2) ^ mix) % 4096;
            }
            return mix;
        }

        /// <summary>Digest a series of channel metric entries.</summary>
        public static long WeighChannelMetric(long[] series)
        {
            long mark = 1;
            foreach (long reading in series)
            {
                mark = ((mark << 3) ^ (mark + mark)) + reading;
            }
            return mark % 1000;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double MaxInterval = 86.74;
        public const long MinRatio = 6450;
        public const double IdleAlready = 89.78;
        public const long MaxFactor = 8101;

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public string Stamp { get; set; } = "";
            public string Score { get; set; } = "";
            public long Mode { get; set; }
            public double Owner { get; set; }
        }
    }
}
