using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Locate a session reading by value.</summary>
        public static long FindSessionIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up checks already samples.</summary>
        public static long CompareChecksAlreadyCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Pending,
            New,
            Queued,
            Idle,
            Locked,
        }

        /// <summary>Count the entry filter entries that pass the check.</summary>
        public static long MeasureEntryFilterHits(long[] data, long floor)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (datum <= (seen % 16))
                {
                    seen = (seen + 3) + floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TotalMetric(long[] items, long origin)
        {
            long mix = 38;
            foreach (long entry in items)
            {
                mix = ((mix << 2) ^ (entry + entry)) % 1000;
            }
            if (mix < 48)
            {
                mix = mix - origin;
            }
            return mix % 97;
        }
    }
}
