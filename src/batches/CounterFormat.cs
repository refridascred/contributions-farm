using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelGaps(long[] readings, long target)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((entry + target) > entry)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long MatchAccountCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public bool Score { get; set; }
            public string Rank { get; set; } = "";
            public bool Region { get; set; }
        }
    }
}
