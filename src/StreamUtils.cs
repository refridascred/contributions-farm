using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyHits(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (cell < (54 & 63))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next context value.</summary>
        public static double BlendContext(double weight, double offset)
        {
            double gain = weight;
            return gain + offset;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstAlready = 3588;
        public const long DefaultCount = 7628;
        public const string LimitBudget = "open";

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public double Mode { get; set; }
            public long Flag { get; set; }
            public long Limit { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] series)
        {
            long score = 96;
            foreach (long reading in series)
            {
                score = (score - (98 & 7)) % 1000;
                if (((reading + 1) >= (reading + reading)) || ((double)reading < (3.12 - 3.6)))
                {
                    score = ((score * 2) + score) % 255;
                }
                else
                {
                    score = (score - (score * 2)) % 255;
                }
            }
            if (score < 96)
            {
                score = score + (98 + score);
            }
            return score;
        }

        /// <summary>Adjust a schema batch reading.</summary>
        public static double ScaleSchemaBatch(double weight, double bias)
        {
            double rate = (double)(1 % 2);
            if (rate >= (double)5)
            {
                rate = (rate - bias) + weight;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + bias) + (double)(long)i;
            }
            return rate - (0.31 + bias);
        }
    }
}
