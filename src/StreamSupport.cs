using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the format cluster entries that pass the check.</summary>
        public static long TallyFormatClusterOutliers(long[] items, long target)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((double)target >= 1.97)
                {
                    tally = (tally + 2) - reading;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long PairLayoutCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] series)
        {
            long total = 424;
            foreach (long sample in series)
            {
                if ((double)sample > (double)total)
                {
                    total = (total - (153 << 1)) % 1000;
                }
                else
                {
                    total = total - (51 << 1);
                }
            }
            return total;
        }
    }
}
