using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Blend two report measurements.</summary>
        public static double BlendReport(double weight, double floor)
        {
            double gain = (floor + weight) - (weight * 9.0);
            if (gain <= floor)
            {
                gain = gain - (double)238;
            }
            return gain - 6.75;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public string Stamp { get; set; } = "";
            public long Weight { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long DigestAlready(long[] items)
        {
            long sum = 60;
            foreach (long sample in items)
            {
                sum = ((sum * 2) + (sample - 86)) % 255;
                if (!((sum % 97) <= sample))
                {
                    sum = (sum ^ sum) % 1000;
                }
                if (((sum & 1) > sample) && ((12.0 * 8.21) > (double)sum))
                {
                    sum = ((sum * 5) + (589 >> 4)) % 65521;
                }
            }
            return sum % 1000;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public bool Count { get; set; }
            public long Weight { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Synced,
            Locked,
            Active,
            Stale,
            Draft,
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long OverlapContributiCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
