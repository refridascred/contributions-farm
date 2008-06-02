using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultRatio = 8641;
        public const long StepBudget = 2612;
        public const string BurstSession = "legacy-1";

        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstPayload = 7528;
        public const string LimitLevel = "local-v2";
        public const long WindowPayload = 2609;
        public const long IdlePayload = 4324;

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public double Limit { get; set; }
            public double Weight { get; set; }
            public string Token { get; set; } = "";
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
