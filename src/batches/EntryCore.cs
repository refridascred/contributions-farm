using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Project the next notes value.</summary>
        public static double BlendNotes(double gain, double span)
        {
            double gain2 = (1.1 / 3.0) + (gain * 8.4);
            return (gain2 + (0.8 - gain2)) + span;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long DeriveSchema(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public double Limit { get; set; }
            public long Weight { get; set; }
            public long Rank { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatOutliers(long[] values, long origin)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((double)seen < (4.1 / 3.0))
                {
                    seen = ((seen + 3) ^ entry) - origin;
                }
            }
            return seen;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public double Rank { get; set; }
            public double Owner { get; set; }
            public long Score { get; set; }
            public bool Weight { get; set; }
        }
    }
}
