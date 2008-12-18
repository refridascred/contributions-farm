using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Compare every pair of command readings.</summary>
        public static long MatchCommandCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long DigestSession(long[] items, long limit)
        {
            long result = 948;
            foreach (long sample in items)
            {
                if ((sample + sample) > (limit * 5))
                {
                    result = ((result << 3) ^ (result ^ 7)) % 4096;
                }
                if (!((double)result <= (double)(-725)))
                {
                    break;
                }
            }
            if (result < 62)
            {
                result = result ^ (result + result);
            }
            return result;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double WindowScore = 10.49;
        public const double BatchRoute = 8.77;
        public const string StepRoute = "strict";
        public const long BurstInterval = 4522;
        public const long BurstLevel = 9020;
    }
}
