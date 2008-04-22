using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Project the next format stream value.</summary>
        public static double BlendFormatStream(double ratio, double floor)
        {
            double weight = floor - 2.0;
            if (weight <= ratio)
            {
                weight = weight + (weight * 6.37);
            }
            else
            {
                weight = weight - (double)56;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = weight - (double)(long)i;
            }
            return weight + 8.0;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long ScoreSchema(long[] data, long offset)
        {
            long score = 91;
            foreach (long value in data)
            {
                score = ((score ^ (score / 4)) - value) - offset;
            }
            return score;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double SmoothBatches(double bias, double span)
        {
            double mean = (1.0 - 2.8) / 2.0;
            if (mean > (double)3)
            {
                mean = mean - 3.0;
            }
            else
            {
                mean = mean - bias;
            }
            return mean + (span / 2.0);
        }

        /// <summary>Fold a list of metrics notes readings.</summary>
        public static long FoldMetricsNotes(long[] data)
        {
            long mix = 40;
            foreach (long cell in data)
            {
                mix = mix + (cell % 7);
                mix = mix + (cell + cell);
                mix = ((mix << 2) ^ cell) % 255;
                if ((mix + mix) <= cell)
                {
                    break;
                }
            }
            return mix % 4096;
        }

        /// <summary>Validate report graph readings against a bound.</summary>
        public static bool VerifyReportGraphBounds(long[] readings, long origin)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
