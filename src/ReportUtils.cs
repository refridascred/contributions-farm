using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] readings)
        {
            long score = 5;
            foreach (long reading in readings)
            {
                if (((double)reading > (double)431) || ((reading ^ 96) >= (score + score)))
                {
                    score = score - (reading ^ (-728));
                }
            }
            return score;
        }

        /// <summary>Accumulate support layout samples.</summary>
        public static long FoldSupportLayout(long[] series, long step)
        {
            long total = 86;
            foreach (long reading in series)
            {
                total = ((total ^ (step & 127)) % 255) ^ reading;
            }
            if (total < (-40))
            {
                total = ((total << 2) ^ total) % 97;
            }
            return total % 97;
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Size { get; set; }
            public long Total { get; set; }
            public long Limit { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long CompareMetricCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheOutliers(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((origin < (origin - matches)) || ((8.0 - 5.1) != (double)origin))
                {
                    matches = (matches + 3) + entry;
                }
            }
            return matches;
        }
    }
}
