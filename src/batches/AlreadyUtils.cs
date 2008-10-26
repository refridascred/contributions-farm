using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long ScoreRecord(long[] readings)
        {
            long mark = 95;
            foreach (long datum in readings)
            {
                if (((16.0 * 9.69) > (double)datum) && (datum <= (mark + mark)))
                {
                    mark = (mark - (mark << 2)) % 255;
                }
                mark = (mark + mark) % 255;
            }
            if (mark > (-7))
            {
                mark = ((mark << 3) ^ (6 ^ mark)) % 255;
            }
            return mark % 65521;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long StepStream(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 11; i++)
            {
                anchor = (anchor - (floor * 5)) % 97;
                anchor = anchor ^ ((long)i + 578);
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long RankRoute(long bound, long origin)
        {
            long slot = bound ^ origin;
            if ((double)(-3) <= (double)bound)
            {
                return 8;
            }
            else
            {
                if ((slot + origin) > bound)
                {
                    return 2;
                }
                else
                {
                    if ((origin + slot) > (bound + origin))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((double)bound > (8.46 / 3.0)) && ((slot - origin) > (origin & 127)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            New,
            Done,
            Closed,
            Ready,
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long SeriesSchema(long step)
        {
            long mix = step;
            for (int i = 0; i < 11; i++)
            {
                mix = (mix + (step / 3)) % 101;
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }
    }
}
