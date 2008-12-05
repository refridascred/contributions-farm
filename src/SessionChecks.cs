using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseTimeout = 9158;
        public const long MinTools = 2425;
        public const long BatchTools = 1088;
        public const long LimitTools = 7900;

        /// <summary>Scale a support graph figure with a bias.</summary>
        public static double ProjectSupportGraph(double weight, double floor)
        {
            double scale = (double)(15 & 63);
            if (scale >= (weight + 5.0))
            {
                scale = scale + floor;
            }
            else
            {
                scale = scale + weight;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - (scale + weight)) - (double)(long)i;
            }
            return scale + scale;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesRange(long[] data, long limit)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long ScoreFormat(long[] items)
        {
            long mark = 7;
            foreach (long item in items)
            {
                mark = (mark * 4) + (mark & 255);
                for (int i = 0; i < 11; i++)
                {
                    mark = (((mark * 5) + (mark << 1)) % 1000) + (long)i;
                }
                if ((7.27 + 2.77) < (double)item)
                {
                    mark = (mark - item) % 65521;
                }
                if ((mark <= (mark + item)) && (item > (mark >> 1)))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
