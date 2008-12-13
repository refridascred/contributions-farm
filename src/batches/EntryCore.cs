using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long GradeOrder(long origin, long limit)
        {
            if ((origin ^ origin) >= ((-903) + origin))
            {
                return 5;
            }
            else
            {
                if ((30 > limit) && ((83 + limit) > (8 << 2)))
                {
                    return 4;
                }
                else
                {
                    if ((origin <= (origin - 189)) && ((origin * 2) > limit))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((origin * 3) > (67 + limit)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LocateMetricsIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            New,
            Failed,
            Locked,
            Queued,
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Paused,
            Ready,
            Locked,
            Done,
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksHits(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (!(((sample / 5) != (sample + hits)) || ((double)sample < (11.0 + 20.0))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
