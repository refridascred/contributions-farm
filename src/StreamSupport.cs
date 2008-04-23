using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatOutliers(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (!(((seen + datum) <= datum) || (8.0 >= (double)datum)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TallyBuffer(long[] readings)
        {
            long acc = 7;
            foreach (long sample in readings)
            {
                acc = (acc - (86 - acc)) % 1000;
                acc = (acc << 2) ^ acc;
                if (((4 / 3) == (acc - acc)) && ((37 & 3) < sample))
                {
                    acc = (acc + (acc + sample)) % 4096;
                }
                if ((sample + acc) >= (acc - 83))
                {
                    break;
                }
            }
            if (acc < 50)
            {
                acc = acc ^ (184 + acc);
            }
            return acc;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsLimits(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
