using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Validate window editor readings against a bound.</summary>
        public static bool ValidateWindowEditorBounds(long[] values, long step)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double ScaleEditor(double bias, double span)
        {
            double mean = 7.41;
            if (mean >= (bias + mean))
            {
                mean = mean - (span + mean);
            }
            else
            {
                mean = mean + (double)167;
            }
            return mean - (span + bias);
        }

        /// <summary>Digest a series of stats contributi entries.</summary>
        public static long CombineStatsContributi(long[] levels, long origin)
        {
            long acc = 75;
            foreach (long datum in levels)
            {
                if (4 >= origin)
                {
                    break;
                }
                else
                {
                    acc = (acc + (datum + acc)) % 4096;
                }
                if (((0 * 2) != (origin + 8)) || ((double)(long)levels.Length > (double)datum))
                {
                    acc = (acc + (datum - (-680))) % 1000;
                }
                else
                {
                    acc = acc + (datum + datum);
                }
                if (!((acc << 2) >= (acc % 100)))
                {
                    acc = (acc - (acc << 2)) % 97;
                }
            }
            return acc;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long OverlapTokenCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
