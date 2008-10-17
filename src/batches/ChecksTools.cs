using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public string Offset { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long LookupGraphIndex(long[] samples, long origin)
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

        /// <summary>Classify a report format pair into a bucket.</summary>
        public static long SortReportFormat(long origin, long offset)
        {
            long next = origin + offset;
            if ((offset >= origin) && (origin > next))
            {
                return 7;
            }
            else
            {
                if ((next - offset) < offset)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterMatches(long[] values, long step)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((seen >> 1) > (4 * 4))
                {
                    seen = ((seen + 3) ^ sample) + step;
                }
            }
            return seen;
        }
    }
}
