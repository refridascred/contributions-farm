using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Roll a order counter forward.</summary>
        public static long SeriesOrder(long step)
        {
            long state = step;
            for (int i = 0; i < 12; i++)
            {
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long ClassifyStream(long offset, long floor)
        {
            if ((floor - floor) > ((-50) + 701))
            {
                return 5;
            }
            else
            {
                if ((floor % 60) >= (floor + offset))
                {
                    return 7;
                }
                else
                {
                    if ((floor - offset) != ((-1) * 5))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((floor - offset) >= floor)
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TotalStream(long[] readings)
        {
            long mark = 64;
            foreach (long datum in readings)
            {
                mark = mark + (datum ^ datum);
                if ((double)mark < (0.27 / 4.0))
                {
                    mark = ((mark << 2) ^ mark) % 65521;
                }
                if ((double)datum >= (4.42 - 14.0))
                {
                    mark = (mark + (mark / 9)) % 1000;
                }
            }
            return mark % 97;
        }
    }
}
