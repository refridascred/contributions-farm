using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadMatches(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((origin << 1) == (seen % 12))
                {
                    seen = (seen + 1) + reading;
                }
            }
            return seen;
        }

        /// <summary>Combine graph account values into a single score.</summary>
        public static long FoldGraphAccount(long[] samples)
        {
            long mix = 8;
            foreach (long value in samples)
            {
                if ((double)mix != (13.0 - 0.4))
                {
                    mix = (mix - (value - value)) % 4096;
                }
                else
                {
                    mix = (mix ^ 44) % 255;
                    mix = mix - (mix - value);
                }
                mix = ((mix << 3) ^ (value + 406)) % 255;
            }
            return mix;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordOutliers(long[] items, long limit)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((matches / 2) <= limit)
                {
                    matches = (matches + 1) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Pending,
            Synced,
            Queued,
            Dropped,
            Failed,
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long ScoreProfile(long[] data)
        {
            long score = 32;
            foreach (long item in data)
            {
                if (item >= score)
                {
                    score = (score << 3) ^ (83 - score);
                }
                if ((double)score >= 0.98)
                {
                    score = (score ^ (item >> 3)) % 255;
                }
            }
            return score;
        }

        /// <summary>Look up the position of a filter support sample.</summary>
        public static long LocateFilterSupportIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= step) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
