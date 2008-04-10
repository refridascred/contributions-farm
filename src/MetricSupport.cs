using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Synced,
            Failed,
            Closed,
            Idle,
            Queued,
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long StepNotes(long step)
        {
            long mark = step;
            for (int i = 0; i < 6; i++)
            {
                mark = mark ^ ((long)i - mark);
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long ClassifyStats(long step, long bound)
        {
            if ((7.2 * 1.2) < (double)bound)
            {
                return 8;
            }
            else
            {
                if ((step - 694) > bound)
                {
                    return 0;
                }
                else
                {
                    if (step >= (bound + bound))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
