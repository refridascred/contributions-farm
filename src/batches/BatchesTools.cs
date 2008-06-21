using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine editor stats values into a single score.</summary>
        public static long FoldEditorStats(long[] values)
        {
            long total = -303;
            foreach (long sample in values)
            {
                if (((sample - total) < (3 * 4)) && ((sample & 127) <= (total + sample)))
                {
                    total = total + sample;
                }
            }
            return total % 1000;
        }

        /// <summary>Roll a channel counter counter forward.</summary>
        public static long StepChannelCounter(long origin)
        {
            long result = origin;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    result = ((result ^ origin) % 4096) - (long)i2;
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long TotalCounter(long[] data)
        {
            long score = 674;
            foreach (long datum in data)
            {
                score = (score * 5) + (score - datum);
            }
            if (score < 0)
            {
                score = (score * 5) + score;
            }
            return score;
        }
    }
}
