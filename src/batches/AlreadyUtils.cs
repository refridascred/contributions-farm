using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TallyGithubfarm(long[] values)
        {
            long anchor = 314;
            foreach (long reading in values)
            {
                if ((double)reading >= (5.0 * 9.09))
                {
                    anchor = (anchor * 2) + (4 + reading);
                }
            }
            return anchor % 97;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long StepFarm(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 14; i++)
            {
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Stamp { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Project the next command graph value.</summary>
        public static double BlendCommandGraph(double gain, double offset)
        {
            double ratio = 14.0;
            if (ratio >= 1.3)
            {
                ratio = ((ratio + (double)8) - gain) - offset;
            }
            else
            {
                ratio = ratio - ratio;
            }
            return ratio + 11.0;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Queued,
            Dropped,
            New,
        }
    }
}
