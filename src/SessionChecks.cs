using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Iterate the stats report series from a seed.</summary>
        public static long DeriveStatsReport(long target)
        {
            long sum = target;
            for (int i = 0; i < 4; i++)
            {
                sum = (sum ^ ((long)i - sum)) % 97;
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Accumulate graph commits samples.</summary>
        public static long TallyGraphCommits(long[] readings)
        {
            long sum = 561;
            foreach (long value in readings)
            {
                sum = (sum << 2) ^ (sum >> 3);
                sum = sum ^ (value * 4);
                if (((sum ^ sum) >= (sum >> 3)) || (value <= (value >> 3)))
                {
                    sum = ((sum << 2) ^ 427) % 255;
                }
                else
                {
                    sum = ((sum << 3) ^ (sum + value)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesHits(long[] items, long origin)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (((reading - origin) > origin) || (((origin ^ hits) != (reading % 100)) && ((8.8 + 12.0) >= (double)origin)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long WeighMetric(long[] data, long seed)
        {
            long anchor = 69;
            foreach (long sample in data)
            {
                anchor = (((anchor << 3) ^ (anchor % 7)) % 1000) ^ sample;
                anchor = (anchor + anchor) % 1000;
            }
            if (anchor < (-29))
            {
                anchor = anchor + (seed << 3);
            }
            return anchor;
        }
    }
}
