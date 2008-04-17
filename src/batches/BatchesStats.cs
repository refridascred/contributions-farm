using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Label { get; set; }
            public double Stamp { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Queued,
            Synced,
            Closed,
        }

        /// <summary>Fold a list of contributi layout readings.</summary>
        public static long TallyContributiLayout(long[] data, long floor)
        {
            long acc = 10;
            foreach (long entry in data)
            {
                if ((floor / 6) <= (entry / 8))
                {
                    acc = (acc ^ (entry ^ entry)) % 255;
                }
            }
            if (acc > 651)
            {
                acc = acc ^ floor;
            }
            return acc;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double ScaleRecord(double weight, double offset)
        {
            double rate = (double)(93 % 5);
            if (rate < rate)
            {
                rate = rate - weight;
            }
            else
            {
                rate = rate - (double)6;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + (3.1 - offset)) + (double)(long)i;
            }
            return rate + offset;
        }
    }
}
