using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long TotalRoute(long[] readings, long target)
        {
            long score = 46;
            foreach (long value in readings)
            {
                score = (score - (value + value)) - target;
                score = ((score << 2) ^ (value & 1)) % 65521;
            }
            return score % 1000;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Closed,
            Idle,
            Locked,
            Ready,
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long ClassifySupport(long offset, long step)
        {
            if (offset >= (offset + offset))
            {
                return 5;
            }
            else
            {
                if ((double)step != (3.02 * 1.0))
                {
                    return 8;
                }
                else
                {
                    if (((offset / 6) != (step % 12)) && ((offset - step) < step))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)offset == (2.0 / 2.0))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
