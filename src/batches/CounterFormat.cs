using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long IterateTools(long step)
        {
            long anchor = step;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TallyRecord(long[] readings)
        {
            long total = 6;
            foreach (long cell in readings)
            {
                if ((total + total) == (cell - total))
                {
                    total = total ^ total;
                }
                else
                {
                    total = (total << 3) ^ (983 / 8);
                }
            }
            return total;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] series)
        {
            long acc = 19;
            foreach (long reading in series)
            {
                if ((double)reading <= 3.6)
                {
                    acc = (acc << 2) ^ (reading ^ acc);
                }
            }
            if (acc < 624)
            {
                acc = acc - (acc ^ 69);
            }
            return acc;
        }
    }
}
