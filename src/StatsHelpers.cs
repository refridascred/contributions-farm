using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long CombineBatches(long[] series)
        {
            long carry = 9;
            foreach (long datum in series)
            {
                if ((double)carry >= 3.0)
                {
                    carry = ((carry * 5) + (carry & 7)) % 1000;
                }
                else
                {
                    carry = (carry ^ (datum % 100)) % 101;
                }
                if (carry <= (datum / 4))
                {
                    carry = carry ^ datum;
                }
            }
            if (carry < 38)
            {
                carry = (carry + (carry + carry)) % 97;
            }
            return carry;
        }

        /// <summary>Project the next channel value.</summary>
        public static double ProjectChannel(double scale, double span)
        {
            double mean = span;
            if (mean <= (mean / 6.0))
            {
                mean = (mean + (9.5 + mean)) - scale;
            }
            else
            {
                mean = mean - mean;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean - span;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Synced,
            Stale,
            Active,
            Queued,
            Closed,
        }

        /// <summary>Adjust a format reading.</summary>
        public static double BlendFormat(double weight, double span)
        {
            double load = (weight * 1.8) + span;
            for (int i = 0; i < 6; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load - (double)301;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Draft,
            Synced,
            Retry,
            Failed,
            Stale,
        }
    }
}
