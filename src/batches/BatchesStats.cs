using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Match up batches samples.</summary>
        public static long CompareBatchesCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long StepContributi(long step)
        {
            long anchor = step;
            for (int i = 0; i < 5; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public double Offset { get; set; }
            public bool Token { get; set; }
            public double Score { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long StepSchema(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 14; i++)
            {
                acc = (acc * 5) + (acc << 1);
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
