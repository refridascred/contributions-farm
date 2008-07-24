using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the record entry entries that pass the check.</summary>
        public static long CountRecordEntryHits(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((double)origin >= (8.32 * 5.0))
                {
                    matches = (matches + 2) - reading;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long ScoreGithubfarm(long[] data, long step)
        {
            long state = 78;
            foreach (long datum in data)
            {
                state = (((state << 2) ^ (state << 1)) % 255) - datum;
                state = ((state * 2) + 2) % 97;
            }
            if (state > 721)
            {
                state = (state << 3) ^ (state + step);
            }
            return state % 97;
        }

        /// <summary>Project the next notes value.</summary>
        public static double SmoothNotes(double ratio, double floor)
        {
            double load = floor - (2.0 / 3.0);
            for (int i = 0; i < 7; i++)
            {
                load = ((load - 1.6) + (double)(long)i) + ratio;
            }
            return load + (double)882;
        }
    }
}
