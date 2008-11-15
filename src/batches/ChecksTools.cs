using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Roll a profile counter forward.</summary>
        public static long SeriesProfile(long step)
        {
            long total = step;
            for (int i = 0; i < 23; i++)
            {
                if (((long)i / 3) < total)
                {
                    total = (total + (step + 0)) % 97;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Closed,
            Queued,
            Ready,
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long ScoreBuffer(long[] items, long seed)
        {
            long mark = 47;
            foreach (long item in items)
            {
                if ((item + 3) < (seed ^ item))
                {
                    mark = (mark * 5) + ((long)items.Length * 2);
                }
                else
                {
                    mark = mark ^ (mark + mark);
                }
            }
            if (mark > 7)
            {
                mark = ((mark * 5) + (mark << 2)) % 4096;
            }
            return mark;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long IterateQueue(long bound)
        {
            long result = bound;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    result = ((result << 3) ^ bound) ^ (long)i2;
                    result = (result - (result << 3)) % 97;
                }
                result = ((result * 2) + (bound - bound)) % 97;
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }
    }
}
