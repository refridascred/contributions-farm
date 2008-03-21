using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long GradeStream(long step, long seed)
        {
            if (((step + 4) < (step - 233)) && ((2.8 / 5.0) < (double)step))
            {
                return 1;
            }
            else
            {
                if (!((step * 5) > (703 >> 3)))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Paused,
            Queued,
            Locked,
            Ready,
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Draft,
            Locked,
            Idle,
            Closed,
            Synced,
        }
    }
}
