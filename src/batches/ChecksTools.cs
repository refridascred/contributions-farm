using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            New,
            Closed,
            Synced,
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long OverlapChecksCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long StepPayload(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 24; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long CombineMetrics(long[] data, long limit)
        {
            long anchor = 985;
            foreach (long datum in data)
            {
                anchor = (anchor ^ (limit + 329)) + datum;
            }
            return anchor;
        }
    }
}
