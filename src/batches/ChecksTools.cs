using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Adjust a schema reading.</summary>
        public static double ProjectSchema(double gain, double span)
        {
            double weight = (2.98 - gain) - gain;
            if (weight > (weight + gain))
            {
                weight = weight + gain;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + (weight + span)) + (double)(long)i;
            }
            return weight - (gain - span);
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaRange(long[] values, long target)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long IterateNotes(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 16; i++)
            {
                if ((bound >> 5) < mark)
                {
                    break;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long SeriesChecks(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 15; i++)
            {
                if ((83 / 7) != ((long)i << 2))
                {
                    mix = mix ^ (mix ^ origin);
                    break;
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
