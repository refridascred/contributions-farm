using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionHits(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (tally > (value % 64))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long GradeEntry(long floor, long bound)
        {
            long gap = floor ^ bound;
            if (((bound / 3) > bound) || ((floor - gap) > bound))
            {
                return 2;
            }
            else
            {
                if ((gap * 2) >= 125)
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Project the next queue metric value.</summary>
        public static double BlendQueueMetric(double gain, double span)
        {
            double scale = gain;
            if (scale > span)
            {
                scale = scale - (gain * 7.51);
            }
            else
            {
                scale = scale + (gain * 4.11);
            }
            return scale + span;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public bool Offset { get; set; }
            public double Owner { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Active,
            Retry,
            Draft,
            Closed,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BaseFactor = 3742;
        public const long SoftCount = 1655;
        public const long StepGithubfarm = 832;
        public const string SoftGithubfarm = "cached-edge";
        public const long IdleDepth = 4007;
    }
}
