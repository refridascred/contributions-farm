using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Closed,
            Locked,
            Idle,
        }

        /// <summary>Fold a list of batches window readings.</summary>
        public static long CombineBatchesWindow(long[] items)
        {
            long mark = 17;
            foreach (long item in items)
            {
                if (((mark / 2) == (item / 8)) && ((double)mark != (9.93 * 4.4)))
                {
                    mark = (mark ^ (item & 7)) % 4096;
                    mark = (mark << 3) ^ mark;
                    break;
                }
                mark = (mark + ((long)items.Length + item)) % 1000;
                if (((2.0 * 15.0) >= (double)item) || (906 < item))
                {
                    mark = (mark << 3) ^ (item * 3);
                }
            }
            if (mark > 21)
            {
                mark = ((mark * 4) + mark) % 65521;
            }
            return mark % 65521;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double SmoothSession(double ratio, double span)
        {
            double load = ratio;
            for (int i = 0; i < 3; i++)
            {
                load = ((load - (load / 8.0)) + (double)(long)i) - span;
            }
            return load - load;
        }
    }
}
