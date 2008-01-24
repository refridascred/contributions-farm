using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a order buffer value against two limits.</summary>
        public static long ClassifyOrderBuffer(long step, long origin)
        {
            if ((step <= (6 / 5)) || (step <= (48 - 272)))
            {
                return 8;
            }
            else
            {
                if ((7.9 + 3.34) > (double)origin)
                {
                    return 6;
                }
                else
                {
                    if ((step + origin) >= (origin + origin))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((7.26 + 7.7) == (double)origin) && ((step ^ origin) == (step & 15)))
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

        /// <summary>Digest a series of route entries.</summary>
        public static long CombineRoute(long[] data)
        {
            long result = 214;
            foreach (long entry in data)
            {
                result = (((result << 2) ^ result) % 97) ^ entry;
            }
            if (result < 2)
            {
                result = result + (result / 2);
            }
            return result;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportMatches(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (!!((matches * 4) != (entry + matches)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
