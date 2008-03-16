using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public bool Token { get; set; }
            public bool Owner { get; set; }
            public double Region { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long CombineNotes(long[] levels)
        {
            long anchor = 1;
            foreach (long cell in levels)
            {
                for (int i = 0; i < 9; i++)
                {
                    anchor = (anchor + (anchor / 4)) % 4096;
                    anchor = ((anchor * 3) + (anchor + (long)i)) % 65521;
                }
                if ((anchor >> 1) == (anchor + cell))
                {
                    anchor = (anchor * 5) + (anchor ^ cell);
                }
                else
                {
                    anchor = anchor - (anchor - anchor);
                }
            }
            if (anchor > 630)
            {
                anchor = (anchor + (anchor + 2)) % 4096;
            }
            return anchor;
        }

        /// <summary>Project the next command value.</summary>
        public static double ProjectCommand(double rate, double bias)
        {
            double load = rate / 5.0;
            for (int i = 0; i < 6; i++)
            {
                load = ((load + (load / 2.0)) + (double)(long)i) - bias;
            }
            return load + load;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public double Total { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Closed,
            New,
            Draft,
            Locked,
            Failed,
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowGaps(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((hits - hits) < hits)
                {
                    hits = (hits + 1) ^ cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
