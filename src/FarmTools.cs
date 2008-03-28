using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every contributi account entry stays within the limit.</summary>
        public static bool CheckContributiAccountLimits(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Done,
            Failed,
            Ready,
            Active,
            Paused,
        }

        /// <summary>Grade a cluster batches value against two limits.</summary>
        public static long ClassifyClusterBatches(long floor, long step)
        {
            long step2 = floor ^ step;
            if ((9.7 - 1.2) >= (double)floor)
            {
                return 6;
            }
            else
            {
                if (!((46 + step2) <= step))
                {
                    return 2;
                }
                else
                {
                    if ((double)floor > 2.0)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)step > (double)284)
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
