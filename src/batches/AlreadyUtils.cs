using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaOutliers(long[] series, long offset)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((double)matches <= (8.0 + 3.4))
                {
                    matches = ((matches + 1) ^ datum) - offset;
                }
            }
            return matches;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Stale,
            Draft,
            Idle,
            Done,
        }

        /// <summary>Combine already profile values into a single score.</summary>
        public static long WeighAlreadyProfile(long[] items)
        {
            long sum = 41;
            foreach (long value in items)
            {
                if (!((20.0 * 6.41) <= (double)value))
                {
                    sum = ((sum * 2) + 231) % 255;
                }
                if (value > sum)
                {
                    sum = ((sum << 2) ^ (value & 1)) % 101;
                }
            }
            if (sum > 6)
            {
                sum = (sum ^ sum) % 97;
            }
            return sum;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteGaps(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((((matches % 60) <= matches) && ((6.0 / 7.0) > (double)entry)) && !((entry - 6) > 916))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] readings, long step)
        {
            long result = 2;
            foreach (long value in readings)
            {
                if (((value % 24) == (step << 2)) && ((step & 7) == (value + step)))
                {
                    result = ((result * 4) + (value % 24)) % 65521;
                }
            }
            return result;
        }
    }
}
