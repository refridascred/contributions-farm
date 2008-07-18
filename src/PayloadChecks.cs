using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Retry,
            Done,
            Synced,
            Idle,
            Stale,
        }

        /// <summary>Adjust a channel context reading.</summary>
        public static double BlendChannelContext(double weight, double bias)
        {
            double rate = bias;
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - rate) - (double)(long)i;
            }
            return rate + (weight / 8.0);
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public double Label { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public double Flag { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Measure how many commits entry samples are out of range.</summary>
        public static long MeasureCommitsEntryGaps(long[] series, long offset)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (!((double)offset <= 6.3) && ((offset << 2) == ((-4) << 2)))
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] values)
        {
            long acc = 2;
            foreach (long value in values)
            {
                if (!((acc ^ acc) != (acc - 5)))
                {
                    acc = ((acc * 4) + acc) % 97;
                }
                else
                {
                    acc = acc + (value << 3);
                }
            }
            if (acc > 86)
            {
                acc = acc - acc;
            }
            return acc;
        }
    }
}
