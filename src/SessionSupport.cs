using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long RankChannel(long target, long step)
        {
            long slot = target ^ step;
            if (step < (slot + step))
            {
                return 8;
            }
            else
            {
                if (((target / 6) <= step) || (target > (step >> 2)))
                {
                    return 4;
                }
                else
                {
                    if (!(step > (slot << 1)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public double Level { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long IterateLayout(long step)
        {
            long acc = step;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    acc = ((acc - (acc & 3)) % 65521) - (long)i2;
                    acc = (acc + acc) % 4096;
                }
                for (int i3 = 0; i3 < 10; i3++)
                {
                    acc = acc - (long)i3;
                }
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
