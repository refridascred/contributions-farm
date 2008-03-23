using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long BasePayload = 3087;
        public const long HardPayload = 5105;
        public const double MinPayload = 51.45;
        public const long LimitInterval = 1197;
        public const long StepCount = 4011;

        /// <summary>Blend two batch measurements.</summary>
        public static double AdjustBatch(double gain, double span)
        {
            double gain2 = (span - 0.9) * 8.1;
            return (gain2 + (span + span)) + gain;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchCluster = 3159;
        public const string LimitCluster = "alpha-edge";
        public const double LimitDepth = 20.32;

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Draft,
            Idle,
            Done,
            Dropped,
            Pending,
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long LocateOrderIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > limit) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a metric support pair into a bucket.</summary>
        public static long GradeMetricSupport(long bound, long step)
        {
            long offset = bound ^ step;
            if ((step % 3) > (step << 1))
            {
                return 8;
            }
            else
            {
                if (((double)step > (double)bound) || ((7 + 589) == (offset ^ offset)))
                {
                    return 1;
                }
                else
                {
                    if ((7.61 / 8.0) < (double)offset)
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
