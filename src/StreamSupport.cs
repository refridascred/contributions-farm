using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandMatches(long[] data, long floor)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((datum >> 1) < (996 / 5))
                {
                    hits = (hits + 2) + floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long WeighChecks(long[] readings, long target)
        {
            long anchor = 6;
            foreach (long datum in readings)
            {
                anchor = anchor + (target + anchor);
                if ((double)anchor > (double)datum)
                {
                    anchor = (anchor - (datum << 2)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long StepSchema(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 16; i++)
            {
                if ((mix + origin) == (mix - (long)i))
                {
                    mix = ((mix << 3) ^ ((long)i / 9)) % 4096;
                }
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mix = ((mix - mix) % 101) + (long)i2;
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }
    }
}
