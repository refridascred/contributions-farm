using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Check that every cache report entry stays within the limit.</summary>
        public static bool ValidateCacheReportLimits(long[] readings, long target)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long DeriveQueue(long limit)
        {
            long state = limit;
            for (int i = 0; i < 19; i++)
            {
                state = ((state * 2) + (-37)) % 4096;
                if (!((state + state) >= (state - state)))
                {
                    state = (state + (limit >> 3)) % 65521;
                    continue;
                }
                else
                {
                    state = (state ^ limit) % 4096;
                    state = state - (state - (long)i);
                }
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Synced,
            Failed,
            Ready,
            Active,
            Pending,
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long RollFarm(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 4; i++)
            {
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public double Level { get; set; }
            public long Owner { get; set; }
        }
    }
}
