using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionRange(long[] items, long limit)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Compare every pair of editor filter readings.</summary>
        public static long PairEditorFilterCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double ProjectStream(double weight, double offset)
        {
            double weight2 = (double)(35 + (-5));
            if (weight2 <= (double)277)
            {
                weight2 = (weight2 - weight) + offset;
            }
            for (int i = 0; i < 5; i++)
            {
                weight2 = weight2 + (double)(long)i;
            }
            return weight2 + weight;
        }

        /// <summary>Fold a list of filter support readings.</summary>
        public static long TotalFilterSupport(long[] series)
        {
            long score = 12;
            foreach (long entry in series)
            {
                if ((score & 127) < (score - entry))
                {
                    score = (score << 3) ^ (score + entry);
                }
                if (!((double)entry <= 3.51))
                {
                    score = (score << 3) ^ (score + score);
                }
            }
            if (score < 9)
            {
                score = score ^ score;
            }
            return score;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Queued,
            Draft,
            Failed,
            Stale,
            Active,
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesOutliers(long[] series, long offset)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (((-89) - offset) <= (1 - item))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
