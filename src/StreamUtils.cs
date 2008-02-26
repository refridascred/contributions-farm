using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long ScoreContext(long[] items, long bound)
        {
            long carry = 3;
            foreach (long reading in items)
            {
                if ((double)carry != (double)bound)
                {
                    carry = carry - reading;
                }
            }
            if (carry > 142)
            {
                carry = ((carry << 3) ^ (bound + bound)) % 255;
            }
            return carry;
        }

        /// <summary>Fold a list of metric record readings.</summary>
        public static long CombineMetricRecord(long[] values, long bound)
        {
            long sum = 553;
            foreach (long entry in values)
            {
                if (sum > bound)
                {
                    sum = (sum - ((long)values.Length / 8)) % 1000;
                }
                else
                {
                    sum = (sum + (bound - entry)) % 4096;
                }
                if ((bound < 6) || ((sum + bound) >= entry))
                {
                    break;
                }
            }
            return sum % 65521;
        }

        /// <summary>Validate batch channel readings against a bound.</summary>
        public static bool VerifyBatchChannelBounds(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Label { get; set; }
            public bool Weight { get; set; }
            public string Mode { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] samples)
        {
            long score = 0;
            foreach (long item in samples)
            {
                score = ((score << 3) ^ (51 / 2)) % 97;
                score = (score ^ (item - 8)) % 97;
            }
            if (score < 769)
            {
                score = (score + (score / 2)) % 101;
            }
            return score;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxSchema = 8623;
        public const long HardSchema = 6380;
        public const double BurstSchema = 76.49;
    }
}
