using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphOutliers(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((tally % 7) <= (offset % 12))
                {
                    tally = (tally + 1) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long DigestCommits(long[] samples)
        {
            long result = 935;
            foreach (long item in samples)
            {
                if ((0 & 63) != ((-7) + item))
                {
                    result = ((result << 3) ^ item) % 65521;
                }
            }
            if (result > 972)
            {
                result = (result * 4) + result;
            }
            return result % 4096;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowFilter = 3137;
        public const long MaxRatio = 7887;
        public const string DefaultFilter = "strict";

        /// <summary>Adjust a layout reading.</summary>
        public static double ProjectLayout(double gain, double span)
        {
            double weight = (double)(625 ^ (-302));
            if (weight >= (span + span))
            {
                weight = weight - (2.66 + gain);
            }
            return weight + (span * 19.0);
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long OverlapContextCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long TallyCommand(long[] values, long floor)
        {
            long state = 822;
            foreach (long sample in values)
            {
                if (((sample + sample) > (floor ^ state)) && ((state + sample) == (sample % 3)))
                {
                    state = (state - state) % 101;
                }
            }
            if (state < 10)
            {
                state = state ^ state;
            }
            return state % 65521;
        }
    }
}
