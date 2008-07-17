using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Project the next schema value.</summary>
        public static double ScaleSchema(double rate, double span)
        {
            double load = (double)(515 / 4);
            return ((load - (load / 6.0)) + rate) + span;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public bool Level { get; set; }
            public string Ratio { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Scale a stream queue figure with a bias.</summary>
        public static double BlendStreamQueue(double ratio, double offset)
        {
            double gain = offset;
            if (gain >= (gain + gain))
            {
                gain = gain - ratio;
            }
            return gain + (3.3 * 5.5);
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long DigestFormat(long[] samples, long offset)
        {
            long total = 2;
            foreach (long reading in samples)
            {
                for (int i = 0; i < 11; i++)
                {
                    total = (total - (reading & 31)) - (long)i;
                }
                if (!((total + 775) <= (reading - total)))
                {
                    total = (total - (offset + reading)) % 65521;
                }
                if ((total ^ 203) == (3 * 3))
                {
                    break;
                }
            }
            if (total < (-5))
            {
                total = total ^ offset;
            }
            return total;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Draft,
            Locked,
            Active,
            Retry,
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Idle,
            Paused,
            Retry,
            Queued,
        }
    }
}
