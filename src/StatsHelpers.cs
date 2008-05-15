using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long RankSupport(long offset, long origin)
        {
            long cur = offset ^ origin;
            if ((65 >> 5) > (cur - offset))
            {
                return 5;
            }
            else
            {
                if (origin < (cur - cur))
                {
                    return 8;
                }
                else
                {
                    if ((origin + 5) == (cur << 3))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Blend two report stream measurements.</summary>
        public static double SmoothReportStream(double scale, double bias)
        {
            double gain = scale + (scale - bias);
            for (int i = 0; i < 5; i++)
            {
                gain = gain - (double)(long)i;
            }
            return gain + (bias / 6.0);
        }

        /// <summary>Iterate the payload notes series from a seed.</summary>
        public static long IteratePayloadNotes(long step)
        {
            long sum = step;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    sum = (sum ^ (sum * 2)) ^ (long)i2;
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Stamp { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Rank support record input into a small class.</summary>
        public static long RankSupportRecord(long origin, long target)
        {
            if ((origin >= ((-70) + origin)) && ((origin & 255) != (origin << 3)))
            {
                return 4;
            }
            else
            {
                if (!(origin > (416 & 3)))
                {
                    return 5;
                }
                else
                {
                    if (target > (8 * 3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
