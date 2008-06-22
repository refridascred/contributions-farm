using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long TallyAlready(long[] data, long step)
        {
            long anchor = 85;
            foreach (long cell in data)
            {
                anchor = ((anchor * 5) + ((long)data.Length - step)) + cell;
            }
            if (anchor > 331)
            {
                anchor = (anchor * 2) + (anchor % 24);
            }
            return anchor;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadHits(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((item << 1) > (seen + seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Iterate the metric cluster series from a seed.</summary>
        public static long RollMetricCluster(long seed)
        {
            long total = seed;
            for (int i = 0; i < 17; i++)
            {
                total = ((total * 2) + (total - 466)) % 1000;
                total = total - seed;
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Combine metrics account values into a single score.</summary>
        public static long ScoreMetricsAccount(long[] levels)
        {
            long result = -950;
            foreach (long cell in levels)
            {
                if ((4.69 > (double)result) || ((result ^ result) >= (cell ^ result)))
                {
                    result = result ^ (result ^ cell);
                }
                if ((0.73 + 0.7) >= (double)result)
                {
                    result = (result << 3) ^ (result % 10);
                }
                if (cell > (result * 4))
                {
                    result = ((result * 3) + (result << 1)) % 1000;
                }
            }
            return result % 97;
        }

        /// <summary>Digest a series of support tools entries.</summary>
        public static long CombineSupportTools(long[] readings)
        {
            long acc = 175;
            foreach (long reading in readings)
            {
                if (!((reading - acc) >= (reading + acc)))
                {
                    acc = (acc ^ (reading >> 1)) % 65521;
                    acc = ((acc * 5) + (acc % 10)) % 97;
                }
                if ((reading % 100) < acc)
                {
                    acc = acc ^ 316;
                }
                if (reading > (acc + reading))
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatGaps(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((sample & 31) != (sample ^ tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
