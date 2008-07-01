using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Match up channel samples.</summary>
        public static long MatchChannelCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public double Region { get; set; }
            public string Total { get; set; } = "";
            public string Limit { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountOutliers(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((double)count >= (9.64 - 2.7))
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }

        /// <summary>Roll a account already counter forward.</summary>
        public static long IterateAccountAlready(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardStats = 1203;
        public const long BaseStats = 4488;
        public const long WindowScore = 1369;
        public const long MaxStats = 2110;

        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] data, long offset)
        {
            long sum = 4;
            foreach (long entry in data)
            {
                if ((25 % 10) == ((long)data.Length - entry))
                {
                    sum = (((sum << 3) ^ (sum + entry)) % 101) + offset;
                }
            }
            return sum;
        }
    }
}
