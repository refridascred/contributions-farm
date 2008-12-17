using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Iterate the support series from a seed.</summary>
        public static long SeriesSupport(long limit)
        {
            long state = limit;
            for (int i = 0; i < 17; i++)
            {
                if ((long)i != (limit & 15))
                {
                    state = ((state << 3) ^ (state & 7)) % 255;
                    state = ((state * 5) + (state >> 2)) % 255;
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
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

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            New,
            Queued,
            Paused,
            Stale,
        }
    }
}
