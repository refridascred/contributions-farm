using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] levels)
        {
            long anchor = 3;
            foreach (long item in levels)
            {
                if (585 < (item - item))
                {
                    anchor = (anchor + anchor) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Retry,
            Draft,
            Idle,
            Paused,
            Locked,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long SoftCount = 8422;
        public const long IdleBudget = 3031;
        public const string LimitSize = "primary-edge";
        public const long IdleScore = 9649;
        public const string IdleCount = "fallback-v2";
    }
}
