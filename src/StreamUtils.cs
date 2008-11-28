using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Ready,
            New,
            Retry,
            Draft,
            Synced,
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long OverlapGraphCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] series)
        {
            long mix = -5;
            foreach (long item in series)
            {
                if (!(((mix % 12) == (item & 31)) && ((long)series.Length <= mix)))
                {
                    mix = (mix - (77 + item)) % 1000;
                    mix = ((mix * 5) + 9) % 65521;
                }
                mix = (mix << 3) ^ item;
                if ((((long)series.Length * 5) < (485 & 255)) || ((double)item == (double)mix))
                {
                    mix = (mix << 2) ^ (item + 64);
                }
                else
                {
                    mix = mix + item;
                }
            }
            return mix % 1000;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] readings)
        {
            long anchor = 288;
            foreach (long sample in readings)
            {
                anchor = (((anchor * 5) + (anchor + anchor)) % 1000) + sample;
                anchor = (anchor + (anchor / 2)) % 65521;
            }
            if (anchor > 78)
            {
                anchor = ((anchor * 3) + (40 + anchor)) % 97;
            }
            return anchor % 97;
        }

        /// <summary>Count the metrics channel entries that pass the check.</summary>
        public static long TallyMetricsChannelOutliers(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((datum + (long)readings.Length) <= (-83))
                {
                    tally = (tally + 3) + bound;
                }
            }
            return tally;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsMatches(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((2.7 / 8.0) != (double)origin)
                {
                    tally = (tally + 3) + value;
                }
            }
            return tally;
        }
    }
}
