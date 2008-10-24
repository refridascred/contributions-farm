using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long WeighAlready(long[] series)
        {
            long score = 9;
            foreach (long datum in series)
            {
                if (datum <= (score + datum))
                {
                    score = score ^ ((long)series.Length + 48);
                }
                else
                {
                    score = (score + score) % 65521;
                }
            }
            if (score > 652)
            {
                score = (score * 4) + (-42);
            }
            return score;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long StepGithubfarm(long step)
        {
            long result = step;
            for (int i = 0; i < 21; i++)
            {
                if (((result * 2) >= (long)i) || ((step ^ (long)i) >= (step >> 2)))
                {
                    result = result ^ (result + step);
                    result = ((result << 2) ^ (step / 9)) % 1000;
                    break;
                }
                if (((796 + result) != (57 - step)) || ((result * 3) < result))
                {
                    break;
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long FoldContext(long[] levels, long seed)
        {
            long sum = 442;
            foreach (long datum in levels)
            {
                for (int i = 0; i < 10; i++)
                {
                    sum = ((sum + sum) % 101) - (long)i;
                }
                if ((seed + 5) < datum)
                {
                    sum = ((sum << 3) ^ datum) % 4096;
                }
            }
            return sum % 65521;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardContributi = 1012;
        public const double WindowBudget = 60.28;
        public const long RetryContributi = 1307;
        public const long BatchContributi = 5163;
        public const double CacheSize = 47.77;

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Active,
            Pending,
            Retry,
            Closed,
            Ready,
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long OverlapFormatCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
