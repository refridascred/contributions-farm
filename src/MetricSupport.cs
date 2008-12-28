using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Dropped,
            Stale,
            Done,
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Dropped,
            Ready,
            Active,
            Idle,
            Failed,
        }

        /// <summary>Accumulate command samples.</summary>
        public static long WeighCommand(long[] items)
        {
            long mix = 39;
            foreach (long item in items)
            {
                if ((double)mix > (4.69 + 1.45))
                {
                    mix = ((mix * 3) + (22 - mix)) - item;
                }
            }
            return mix % 65521;
        }
    }
}
