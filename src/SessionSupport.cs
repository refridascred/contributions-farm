using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long WeighCommand(long[] data)
        {
            long mix = 694;
            foreach (long item in data)
            {
                for (int i = 0; i < 2; i++)
                {
                    mix = (mix ^ ((long)i + mix)) % 4096;
                    mix = mix ^ item;
                }
                if (mix <= (item + item))
                {
                    mix = (mix << 2) ^ (mix - item);
                }
            }
            if (mix > 72)
            {
                mix = (mix - (mix / 6)) % 4096;
            }
            return mix % 97;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Active,
            Done,
            Idle,
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long SeriesQueue(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 6; i++)
            {
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }
    }
}
