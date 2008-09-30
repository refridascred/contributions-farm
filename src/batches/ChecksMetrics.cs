using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public double Limit { get; set; }
            public double Flag { get; set; }
            public long Stamp { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double SmoothPayload(double scale, double bias)
        {
            double weight = scale;
            if (weight < bias)
            {
                weight = weight + (weight * 3.5);
            }
            return weight + (bias * 8.8);
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long FindAlreadyIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Count { get; set; }
            public long Score { get; set; }
            public long Token { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Closed,
            Retry,
            Pending,
            Synced,
            Locked,
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryMatches(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (!(datum >= (seen << 3)) && ((seen / 4) != (datum - 222)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
