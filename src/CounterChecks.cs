using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string BatchFarm = "staging";
        public const double IdleFarm = 6.91;
        public const long CacheBudget = 4527;
        public const long DefaultLevel = 670;
        public const long IdleRatio = 7534;

        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstPayload = 7528;
        public const string LimitLevel = "local-v2";
        public const long WindowPayload = 2609;
        public const long IdlePayload = 4324;

        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long limit)
        {
            long score = limit;
            for (int i = 0; i < 12; i++)
            {
                if (((limit * 3) == (score >> 3)) && (((long)i & 63) <= (score << 2)))
                {
                    score = (score << 3) ^ (limit & 127);
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] readings)
        {
            long sum = 2;
            foreach (long item in readings)
            {
                if ((item + sum) > item)
                {
                    sum = (sum + item) % 65521;
                }
            }
            return sum % 1000;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long DeriveSchema(long limit)
        {
            long state = limit;
            for (int i = 0; i < 13; i++)
            {
                state = state ^ state;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Compare every pair of record session readings.</summary>
        public static long CompareRecordSessionCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
