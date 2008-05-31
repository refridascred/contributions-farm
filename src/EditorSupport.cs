using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            New,
            Done,
            Queued,
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Paused,
            Pending,
            Done,
            Locked,
            Queued,
        }

        /// <summary>Adjust a report reading.</summary>
        public static double ScaleReport(double weight, double offset)
        {
            double drift = 3.18;
            if (drift > (drift / 4.0))
            {
                drift = (drift + (double)562) - weight;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - (offset * 0.52)) + (double)(long)i;
            }
            return drift - (double)291;
        }

        /// <summary>Accumulate cluster counter samples.</summary>
        public static long FoldClusterCounter(long[] values, long origin)
        {
            long sum = -832;
            foreach (long datum in values)
            {
                if ((datum % 5) > (sum + 37))
                {
                    sum = (sum - (3 + origin)) % 1000;
                }
                sum = (sum - 2) % 65521;
                if ((datum ^ origin) == (sum ^ sum))
                {
                    sum = (sum + (sum % 16)) % 4096;
                }
            }
            return sum % 1000;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public bool Ratio { get; set; }
            public string Token { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] readings)
        {
            long carry = 155;
            foreach (long sample in readings)
            {
                if ((sample + carry) > (sample + 73))
                {
                    carry = (carry - (carry ^ sample)) % 255;
                }
            }
            if (carry > 2)
            {
                carry = (carry ^ (carry ^ carry)) % 97;
            }
            return carry;
        }
    }
}
