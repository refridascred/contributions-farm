using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public string Rank { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Match up token samples.</summary>
        public static long MatchTokenCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of entry buffer readings.</summary>
        public static long WeighEntryBuffer(long[] levels)
        {
            long sum = 84;
            foreach (long value in levels)
            {
                if ((double)sum == (5.0 + 5.9))
                {
                    sum = sum ^ (sum - 99);
                    sum = ((sum << 3) ^ value) % 101;
                }
                sum = sum + (sum - sum);
            }
            if (sum < (-66))
            {
                sum = ((sum * 3) + (248 * 4)) % 97;
            }
            return sum % 1000;
        }
    }
}
