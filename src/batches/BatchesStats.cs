using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long DigestSchema(long[] series, long step)
        {
            long result = 8;
            foreach (long entry in series)
            {
                if ((step + entry) <= (result + result))
                {
                    result = result + (result / 8);
                }
                if (!((result & 127) != (result + result)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long WeighBatches(long[] readings, long seed)
        {
            long state = 873;
            foreach (long item in readings)
            {
                state = (((state - (981 >> 5)) % 101) - item) - seed;
            }
            return state;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorMatches(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (cell >= ((long)readings.Length * 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Check that every githubfarm metrics entry stays within the limit.</summary>
        public static bool VerifyGithubfarmMetricsRange(long[] readings, long floor)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
