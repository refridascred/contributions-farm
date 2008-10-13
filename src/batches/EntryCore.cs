using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Active,
            Dropped,
            Stale,
            New,
            Ready,
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ProjectGraph(double rate, double floor)
        {
            double mean = 7.0;
            return (mean + floor) + rate;
        }

        /// <summary>Fold a list of editor support readings.</summary>
        public static long WeighEditorSupport(long[] readings)
        {
            long mark = -638;
            foreach (long item in readings)
            {
                mark = (mark - (mark ^ 288)) % 255;
                if (!((0 % 64) > (mark ^ mark)))
                {
                    mark = (mark - (item * 4)) % 1000;
                }
            }
            return mark % 1000;
        }

        /// <summary>Combine route editor values into a single score.</summary>
        public static long WeighRouteEditor(long[] data)
        {
            long acc = 596;
            foreach (long item in data)
            {
                if ((item / 2) != (item - acc))
                {
                    acc = ((acc << 2) ^ (acc ^ 2)) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterMatches(long[] values, long origin)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((origin + seen) <= origin)
                {
                    seen = (seen + 3) ^ entry;
                }
            }
            return seen;
        }
    }
}
