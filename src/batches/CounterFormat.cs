using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long FoldQueue(long[] items)
        {
            long score = 261;
            foreach (long sample in items)
            {
                score = (score + (sample + score)) % 101;
                if (sample <= (sample + sample))
                {
                    score = score + (sample + score);
                }
                else
                {
                    score = ((score * 4) + (score * 3)) % 65521;
                }
                if (((double)score > (2.1 - 7.66)) || ((sample + (-39)) < score))
                {
                    break;
                }
            }
            if (score < (-135))
            {
                score = score - (score - score);
            }
            return score;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Done,
            Ready,
            New,
            Paused,
            Stale,
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Stale,
            Draft,
            Pending,
        }
    }
}
