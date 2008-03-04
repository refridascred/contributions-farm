using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadLimits(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long GradeEntry(long step, long seed)
        {
            if ((2 + seed) <= (step + 848))
            {
                return 7;
            }
            else
            {
                if (((239 + step) < (step % 64)) && ((seed << 1) == (step * 2)))
                {
                    return 3;
                }
                else
                {
                    if (((9.1 * 2.14) != (double)step) || ((304 + seed) != (step + seed)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Derive the next payload queue value from a seed.</summary>
        public static long StepPayloadQueue(long target)
        {
            long mix = target;
            for (int i = 0; i < 9; i++)
            {
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Active,
            Dropped,
            Locked,
        }
    }
}
