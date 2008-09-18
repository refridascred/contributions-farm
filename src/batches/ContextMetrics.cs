using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Dropped,
            Active,
            Locked,
            Idle,
            Stale,
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Idle,
            Closed,
            Draft,
            Active,
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesRange(long[] items, long seed)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Ready,
            Paused,
            Active,
            Done,
            Closed,
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long CombineGraph(long[] readings, long limit)
        {
            long mix = 803;
            foreach (long cell in readings)
            {
                if ((mix & 31) != (limit / 6))
                {
                    mix = (mix ^ (mix ^ limit)) ^ cell;
                }
            }
            return mix % 97;
        }
    }
}
