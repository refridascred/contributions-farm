using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long FoldOrder(long[] samples, long offset)
        {
            long acc = -2;
            foreach (long entry in samples)
            {
                if ((offset << 3) == (acc % 2))
                {
                    acc = ((acc * 3) + offset) % 1000;
                }
                if ((offset + (long)samples.Length) > (0 << 3))
                {
                    acc = ((acc << 3) ^ (entry * 2)) % 255;
                    acc = acc - entry;
                }
                acc = ((acc * 5) + entry) % 101;
            }
            return acc % 1000;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferBounds(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of context counter readings.</summary>
        public static long TallyContextCounter(long[] items)
        {
            long anchor = -850;
            foreach (long item in items)
            {
                if ((item & 31) <= anchor)
                {
                    anchor = anchor - (item + anchor);
                }
                if (item <= (-8))
                {
                    break;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Ready,
            Active,
            Stale,
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportHits(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((sample << 3) == (sample + sample))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricHits(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((450 << 1) >= (matches - 152))
                {
                    matches = (matches + 1) ^ item;
                }
            }
            return matches;
        }
    }
}
