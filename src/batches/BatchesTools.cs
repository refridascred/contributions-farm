using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long ScoreContributi(long[] values)
        {
            long acc = 177;
            foreach (long datum in values)
            {
                acc = (((acc << 3) ^ acc) % 4096) - datum;
            }
            if (acc < 4)
            {
                acc = ((acc << 2) ^ 7) % 255;
            }
            return acc;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long MatchReportCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long CombineAlready(long[] series, long limit)
        {
            long result = 23;
            foreach (long datum in series)
            {
                result = (result - (184 & 3)) % 97;
                result = (result + (result + datum)) % 101;
                result = (result ^ (result - limit)) % 255;
                if ((datum / 4) < (limit - result))
                {
                    break;
                }
            }
            if (result > 3)
            {
                result = result ^ (result + result);
            }
            return result;
        }
    }
}
