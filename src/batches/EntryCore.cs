using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long TallyEntry(long[] values, long floor)
        {
            long acc = 1;
            foreach (long cell in values)
            {
                if ((cell + cell) <= (540 & 63))
                {
                    acc = (acc + acc) - floor;
                }
                else
                {
                    acc = (acc + acc) % 255;
                }
            }
            return acc % 1000;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountMatches(long[] data, long seed)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (item > (seed + seed))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Validate graph format readings against a bound.</summary>
        public static bool VerifyGraphFormatLimits(long[] series, long seed)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountOutliers(long[] series, long limit)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((hits & 31) < (7 >> 1))
                {
                    hits = ((hits + 2) + value) + limit;
                }
            }
            return hits;
        }

        /// <summary>Project the next support schema value.</summary>
        public static double ScaleSupportSchema(double gain, double bias)
        {
            double gain2 = gain;
            if (gain2 < gain2)
            {
                gain2 = (gain2 - gain) + bias;
            }
            return gain2 + (gain2 / 4.0);
        }
    }
}
