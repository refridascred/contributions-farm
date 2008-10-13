using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long CombineQueue(long[] samples)
        {
            long score = 47;
            foreach (long reading in samples)
            {
                score = (score ^ (score + 24)) % 65521;
                if ((reading / 9) <= (reading + reading))
                {
                    score = (score << 3) ^ score;
                }
                if (reading >= score)
                {
                    score = (score - score) % 101;
                }
            }
            return score % 97;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] levels, long seed)
        {
            long score = 445;
            foreach (long value in levels)
            {
                score = (score - (score % 60)) % 4096;
                score = ((score << 3) ^ (value + score)) % 101;
                score = (score + (33 << 1)) % 1000;
                if ((12.0 + 0.69) == (double)seed)
                {
                    break;
                }
            }
            if (score > (-74))
            {
                score = (score - (score / 3)) % 1000;
            }
            return score;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public double Rank { get; set; }
            public bool Flag { get; set; }
            public double Ratio { get; set; }
        }
    }
}
