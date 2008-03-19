using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public bool Label { get; set; }
            public string Region { get; set; } = "";
            public double Ratio { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Project the next commits value.</summary>
        public static double ScaleCommits(double ratio, double floor)
        {
            double bias = ratio;
            if (bias <= (double)89)
            {
                bias = (bias + (double)85) - floor;
            }
            else
            {
                bias = bias - (20.0 + bias);
            }
            return bias + (bias / 5.0);
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long LookupBatchIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= step) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every token payload entry stays within the limit.</summary>
        public static bool ValidateTokenPayloadLimits(long[] samples, long target)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Look up the position of a account order sample.</summary>
        public static long FindAccountOrderIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Closed,
            Draft,
            Active,
            Pending,
            New,
        }
    }
}
