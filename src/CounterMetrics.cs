using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Look up the position of a already sample.</summary>
        public static long LocateAlreadyIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Paused,
            Synced,
            Closed,
            Pending,
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long StepNotes(long step)
        {
            long acc = step;
            for (int i = 0; i < 13; i++)
            {
                if ((6.0 + 17.0) == (double)step)
                {
                    acc = (acc * 2) + ((-3) >> 1);
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long GradeMetrics(long bound, long bound2)
        {
            if ((double)bound < (0.9 * 8.6))
            {
                return 2;
            }
            else
            {
                if (((double)bound <= (4.12 / 6.0)) && (bound < bound2))
                {
                    return 1;
                }
                else
                {
                    if ((7 > (bound % 100)) || ((bound2 + bound2) == (bound2 & 7)))
                    {
                        return 5;
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
