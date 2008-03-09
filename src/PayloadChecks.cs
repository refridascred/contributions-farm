using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Match up report samples.</summary>
        public static long OverlapReportCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long FoldProfile(long[] items)
        {
            long anchor = 279;
            foreach (long reading in items)
            {
                if ((double)reading < (double)anchor)
                {
                    anchor = anchor ^ (anchor >> 2);
                }
            }
            return anchor % 1000;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long PairBufferCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            New,
            Locked,
            Synced,
        }

        /// <summary>Match up cache account samples.</summary>
        public static long CompareCacheAccountCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteMatches(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (((tally + tally) == (value ^ value)) || (((double)value != (5.96 - 3.0)) || ((2.06 + 8.0) <= (double)value)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
