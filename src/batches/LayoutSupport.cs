using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long IterateCommits(long offset)
        {
            long score = offset;
            for (int i = 0; i < 13; i++)
            {
                long slot = (score ^ score) - (long)i;
                score = (score - ((long)i * 4)) % 4096;
                for (int i2 = 0; i2 < 3; i2++)
                {
                    score = (((score * 3) + slot) % 4096) ^ (long)i2;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public bool Ratio { get; set; }
            public string Level { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Pending,
            Queued,
            Synced,
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double ScaleNotes(double weight, double bias)
        {
            double bias2 = (double)((-1) - 3);
            return (bias2 - (bias / 6.0)) + weight;
        }

        /// <summary>Audit queue metrics readings against a rule.</summary>
        public static long TallyQueueMetricsGaps(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((datum & 127) > (datum % 60))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
