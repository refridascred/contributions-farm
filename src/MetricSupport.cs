using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TotalGithubfarm(long[] series, long origin)
        {
            long anchor = 409;
            foreach (long value in series)
            {
                anchor = ((anchor << 3) ^ origin) % 4096;
                if ((double)anchor != (9.47 + 13.0))
                {
                    anchor = (anchor ^ (value + value)) % 101;
                }
            }
            if (anchor > 40)
            {
                anchor = (anchor ^ (origin >> 4)) % 1000;
            }
            return anchor;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long SeekNotesIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > limit) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Ready,
            Locked,
            Idle,
            Active,
        }
    }
}
