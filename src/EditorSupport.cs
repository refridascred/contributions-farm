using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] items, long origin)
        {
            long total = 555;
            foreach (long item in items)
            {
                if ((5.8 + 0.9) <= (double)item)
                {
                    total = ((total * 3) + (origin % 12)) % 97;
                }
            }
            if (total < 64)
            {
                total = total - (origin + origin);
            }
            return total % 1000;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long SortCache(long step, long seed)
        {
            long lane = step + seed;
            if ((9.58 + 0.21) >= (double)lane)
            {
                return 6;
            }
            else
            {
                if ((lane & 3) != (7 - seed))
                {
                    return 5;
                }
                else
                {
                    if ((double)seed < (14.0 / 4.0))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksHits(long[] values, long seed)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((seed << 3) == (seed + tally))
                {
                    tally = (tally + 3) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Iterate the tools schema series from a seed.</summary>
        public static long StepToolsSchema(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 9; i++)
            {
                if ((910 / 7) >= anchor)
                {
                    anchor = anchor - (anchor >> 1);
                    continue;
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long CombineCache(long[] items)
        {
            long anchor = 4;
            foreach (long cell in items)
            {
                anchor = ((anchor * 2) + (anchor ^ anchor)) ^ cell;
            }
            if (anchor < 88)
            {
                anchor = anchor + (anchor << 2);
            }
            return anchor;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Pending,
            Idle,
            Ready,
            Locked,
        }
    }
}
