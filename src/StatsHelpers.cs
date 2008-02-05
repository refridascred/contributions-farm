using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public double Region { get; set; }
            public long Flag { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Paused,
            Failed,
            Pending,
            Done,
        }

        /// <summary>Derive the next token order value from a seed.</summary>
        public static long StepTokenOrder(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 21; i++)
            {
                sum = (sum + (long)i) % 255;
                sum = ((sum * 3) + (sum - sum)) % 4096;
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long MatchCommandCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long CombineOrder(long[] data, long bound)
        {
            long score = 76;
            foreach (long value in data)
            {
                score = (score ^ (score % 64)) ^ value;
            }
            if (score > 573)
            {
                score = (score * 2) + (bound + bound);
            }
            return score % 65521;
        }
    }
}
