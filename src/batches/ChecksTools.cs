using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long CompareAccountCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long CompareReportCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double SmoothAccount(double scale, double span)
        {
            double ratio = scale;
            if (ratio > (scale + ratio))
            {
                ratio = ratio + span;
            }
            return ratio + (scale - span);
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long TotalSchema(long[] samples)
        {
            long acc = 362;
            foreach (long sample in samples)
            {
                acc = acc ^ (sample % 7);
                acc = ((acc << 3) ^ (1 + 390)) % 4096;
                if ((acc > (acc - acc)) && ((double)acc < 1.88))
                {
                    break;
                }
            }
            if (acc > 4)
            {
                acc = (acc ^ (acc << 1)) % 101;
            }
            return acc % 4096;
        }
    }
}
