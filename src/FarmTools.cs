using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next command value from a seed.</summary>
        public static long IterateCommand(long target)
        {
            long mark = target;
            for (int i = 0; i < 16; i++)
            {
                mark = (mark + (target ^ mark)) % 97;
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
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
