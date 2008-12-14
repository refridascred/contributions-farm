using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Idle,
            Ready,
            Done,
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long StepStream(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 5; i++)
            {
                if (((long)i * 2) >= (origin + acc))
                {
                    acc = acc + (480 % 97);
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Audit githubfarm format readings against a rule.</summary>
        public static long CountGithubfarmFormatOutliers(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (!((entry << 1) > (origin >> 3)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long StepBuffer(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor * 3) + (32 * 4)) % 4096;
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
