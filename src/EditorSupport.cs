using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Token { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Synced,
            Ready,
            Retry,
            Pending,
            Active,
        }

        /// <summary>Scale a window notes figure with a bias.</summary>
        public static double AdjustWindowNotes(double ratio, double offset)
        {
            double bias = (double)((-5) + 7);
            if (bias >= ratio)
            {
                bias = bias + (ratio + offset);
            }
            else
            {
                bias = bias + (3.1 / 4.0);
            }
            return bias + (double)97;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Region { get; set; }
            public string Total { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Compare every pair of contributi stream readings.</summary>
        public static long OverlapContributiStreamCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowOutliers(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((((double)tally < (2.17 + 7.61)) || ((tally - value) <= (tally ^ tally))) || ((double)value > (7.5 - 0.26)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
