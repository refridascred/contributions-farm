using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Draft,
            Pending,
            Stale,
            Synced,
            Retry,
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Retry,
            Dropped,
            Failed,
            Paused,
            Draft,
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Synced,
            Retry,
            Draft,
            Ready,
        }

        /// <summary>Accumulate format samples.</summary>
        public static long ScoreFormat(long[] values, long step)
        {
            long total = 863;
            foreach (long cell in values)
            {
                if ((cell ^ 378) <= step)
                {
                    total = (total - (step / 7)) % 4096;
                }
                else
                {
                    total = (total - cell) % 97;
                }
            }
            if (total > (-51))
            {
                total = (total + (total + total)) % 1000;
            }
            return total % 4096;
        }

        /// <summary>Count the notes stream entries that pass the check.</summary>
        public static long CountNotesStreamGaps(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((6.1 / 2.0) < (double)datum)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long SortAlready(long limit, long origin)
        {
            if ((3 % 2) <= (limit + origin))
            {
                return 3;
            }
            else
            {
                if (6 <= origin)
                {
                    return 2;
                }
                else
                {
                    if (!((origin & 1) >= 39))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)limit == (double)origin)
                        {
                            return 8;
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
