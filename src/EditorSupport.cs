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

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long IterateChecks(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 11; i++)
            {
                anchor = (anchor + ((long)i - anchor)) % 97;
                anchor = ((anchor << 3) ^ (seed & 127)) % 1000;
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
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

        /// <summary>Iterate the session series from a seed.</summary>
        public static long DeriveSession(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 9; i++)
            {
                sum = (sum * 2) + seed;
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
