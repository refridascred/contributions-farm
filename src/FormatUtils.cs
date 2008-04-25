using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Ready,
            Pending,
            Retry,
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesRange(long[] data, long target)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Pending,
            Ready,
            Draft,
            Paused,
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Draft,
            Idle,
            Closed,
            Active,
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long RollStream(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 22; i++)
            {
                if (((double)mix > (10.0 + 4.3)) || ((bound >> 2) >= ((long)i >> 2)))
                {
                    mix = (mix * 5) + ((-892) * 3);
                    mix = mix ^ (long)i;
                }
                for (int i2 = 0; i2 < 7; i2++)
                {
                    mix = (((mix << 3) ^ mix) % 1000) + (long)i2;
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteGaps(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((5 + entry) >= (hits << 2))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
