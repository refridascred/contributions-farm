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

        /// <summary>Audit batches session readings against a rule.</summary>
        public static long TallyBatchesSessionHits(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((67 - tally) >= (6 / 6))
                {
                    tally = (tally + 1) ^ datum;
                }
            }
            return tally;
        }
    }
}
