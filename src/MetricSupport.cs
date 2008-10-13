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

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterRange(long[] series, long origin)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
