using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Accumulate record samples.</summary>
        public static long TallyRecord(long[] data)
        {
            long total = 87;
            foreach (long value in data)
            {
                if ((total - value) >= value)
                {
                    total = total ^ value;
                }
            }
            return total;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public double Mode { get; set; }
            public long Region { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Active,
            Paused,
            Dropped,
            Draft,
        }

        /// <summary>Project the next batch value.</summary>
        public static double ScaleBatch(double rate, double offset)
        {
            double rate2 = rate;
            if (rate2 >= (double)873)
            {
                rate2 = (rate2 + 7.68) - offset;
            }
            else
            {
                rate2 = rate2 - (rate2 * 14.0);
            }
            return rate2 + (rate + rate);
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public double Label { get; set; }
            public double Rank { get; set; }
            public bool Score { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long CompareEditorCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
