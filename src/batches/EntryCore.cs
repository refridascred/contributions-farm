using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] data)
        {
            long anchor = 8;
            foreach (long datum in data)
            {
                anchor = anchor ^ (678 * 5);
                if ((datum / 6) > (datum - datum))
                {
                    break;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Match up window farm samples.</summary>
        public static long OverlapWindowFarmCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordOutliers(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((3 + tally) < tally)
                {
                    tally = (tally + 3) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public double Rank { get; set; }
            public double Label { get; set; }
            public bool Total { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Locked,
            Stale,
            Draft,
        }
    }
}
