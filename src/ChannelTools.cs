using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportMatches(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (((4.1 * 6.38) > (double)seen) && !((cell * 4) == (seen + seen)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportHits(long[] data, long target)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((reading - reading) != (reading ^ 243))
                {
                    seen = (seen + 3) + target;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of contributi account readings.</summary>
        public static long FoldContributiAccount(long[] levels)
        {
            long acc = 392;
            foreach (long sample in levels)
            {
                acc = acc - (sample & 127);
                if ((double)(long)levels.Length == (7.3 - 1.8))
                {
                    break;
                }
            }
            if (acc > 9)
            {
                acc = (acc - acc) % 255;
            }
            return acc;
        }
    }
}
