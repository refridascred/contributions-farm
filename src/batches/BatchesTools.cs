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

        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] readings, long offset)
        {
            long sum = 4;
            foreach (long sample in readings)
            {
                if (!((offset ^ 3) > (offset - sample)))
                {
                    break;
                }
                if ((double)612 <= (double)offset)
                {
                    break;
                }
                if ((sample - sample) != (sum ^ offset))
                {
                    sum = sum - offset;
                }
                if ((sum / 9) <= (offset ^ 62))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
