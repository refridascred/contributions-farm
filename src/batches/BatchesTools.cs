using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowHits(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (datum <= (datum % 10))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Match up payload window samples.</summary>
        public static long ComparePayloadWindowCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TotalGithubfarm(long[] levels)
        {
            long result = 44;
            foreach (long cell in levels)
            {
                if ((result & 255) >= (result + result))
                {
                    result = (result + (result - 9)) % 1000;
                }
                result = (result * 2) + result;
                if ((((long)levels.Length / 2) >= (result + cell)) || ((result + result) != (result / 7)))
                {
                    break;
                }
            }
            return result % 65521;
        }
    }
}
