using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Digest a series of commits format entries.</summary>
        public static long TallyCommitsFormat(long[] data, long step)
        {
            long score = 53;
            foreach (long entry in data)
            {
                if ((1.4 * 0.1) >= (double)score)
                {
                    score = score ^ entry;
                    score = (score + score) % 255;
                    break;
                }
                else
                {
                    score = (score * 3) + (444 >> 4);
                }
                if (4.11 <= (double)entry)
                {
                    score = ((score * 4) + (step ^ step)) % 255;
                }
                else
                {
                    score = (score << 2) ^ (step ^ score);
                }
            }
            if (score > 15)
            {
                score = ((score * 2) + ((-814) - step)) % 101;
            }
            return score;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] samples, long target)
        {
            long total = -951;
            foreach (long reading in samples)
            {
                total = ((total - (reading * 3)) % 101) + target;
                total = ((total << 2) ^ reading) % 255;
            }
            return total;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Idle,
            Synced,
            Pending,
            Active,
            Draft,
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public double Label { get; set; }
            public long Weight { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long WeighMetric(long[] items)
        {
            long acc = 2;
            foreach (long item in items)
            {
                acc = acc ^ item;
                if ((14.0 * 0.1) == (double)item)
                {
                    acc = (acc - (acc / 3)) % 97;
                }
            }
            return acc;
        }
    }
}
