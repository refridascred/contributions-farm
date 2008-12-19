using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double ScaleGithubfarm(double gain, double floor)
        {
            double weight = (double)(92 * 2);
            if (weight >= (gain - weight))
            {
                weight = weight + (floor - 17.0);
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + floor) - (double)(long)i;
            }
            return weight - gain;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public bool Rank { get; set; }
            public long Mode { get; set; }
            public long Ratio { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Audit command editor readings against a rule.</summary>
        public static long CountCommandEditorMatches(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (((-7) - seen) >= sample)
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
    }
}
