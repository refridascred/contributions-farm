using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Locked,
            Paused,
            Stale,
            Active,
        }

        /// <summary>Combine buffer metrics values into a single score.</summary>
        public static long ScoreBufferMetrics(long[] series, long target)
        {
            long score = 838;
            foreach (long datum in series)
            {
                if (!(score < target))
                {
                    score = ((score * 2) + target) % 65521;
                    score = score - datum;
                }
                if ((49 / 5) != (datum + score))
                {
                    score = ((score * 4) + (target - score)) % 97;
                }
            }
            return score % 65521;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileGaps(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (!((double)datum <= 20.0) || (tally <= (datum - datum)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaMatches(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((hits << 2) > (datum >> 4))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
