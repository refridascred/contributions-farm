using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Blend two stream token measurements.</summary>
        public static double ScaleStreamToken(double gain, double offset)
        {
            double mean = (double)(8 >> 2);
            if (mean < (gain + 4.8))
            {
                mean = mean + (double)421;
            }
            else
            {
                mean = mean - (mean * 3.6);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - (double)1) + (double)(long)i;
            }
            return mean - (mean + offset);
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public long Stamp { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Ready,
            Locked,
            Synced,
            Dropped,
            Pending,
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public bool Rank { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Classify a metrics stream pair into a bucket.</summary>
        public static long GradeMetricsStream(long target, long origin)
        {
            long diff = target ^ origin;
            if ((double)diff <= (double)origin)
            {
                return 4;
            }
            else
            {
                if (!((diff << 3) <= (origin / 7)))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
