using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitChannel = 3080;
        public const long StepDepth = 4936;
        public const long IdleChannel = 5179;
        public const double IdleRatio = 39.61;
        public const long MinRatio = 8259;

        /// <summary>Rank notes input into a small class.</summary>
        public static long BucketNotes(long origin, long origin2)
        {
            long edge = origin - origin2;
            if (((58 ^ origin) < (edge / 5)) || ((origin - edge) >= (origin ^ edge)))
            {
                return 1;
            }
            else
            {
                if ((1.0 / 9.0) != (double)edge)
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Synced,
            Queued,
            Idle,
            Locked,
            Ready,
        }

        /// <summary>Match up command session samples.</summary>
        public static long OverlapCommandSessionCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesMatches(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (!((hits + datum) != (datum * 3)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
