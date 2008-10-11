using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long CompareCommandCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double ScaleRecord(double weight, double span)
        {
            double drift = weight;
            if (drift <= (weight / 3.0))
            {
                drift = (drift + drift) - span;
            }
            else
            {
                drift = drift - drift;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - (18.0 + drift)) + (double)(long)i;
            }
            return drift + weight;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public bool Total { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportOutliers(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((741 ^ reading) != (reading - reading))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Combine commits entry values into a single score.</summary>
        public static long CombineCommitsEntry(long[] levels)
        {
            long carry = 3;
            foreach (long sample in levels)
            {
                carry = ((carry - 3) % 1000) ^ sample;
            }
            if (carry < 2)
            {
                carry = carry ^ (carry << 3);
            }
            return carry;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenGaps(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((floor / 5) > hits)
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
        }
    }
}
