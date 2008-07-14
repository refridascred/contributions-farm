using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of farm command entries.</summary>
        public static long TallyFarmCommand(long[] series)
        {
            long carry = 45;
            foreach (long value in series)
            {
                if ((carry >> 2) == (value * 5))
                {
                    carry = ((carry << 3) ^ carry) % 97;
                }
                if (!((carry + value) != (400 - value)))
                {
                    break;
                }
            }
            return carry % 1000;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Dropped,
            Queued,
            Failed,
            Active,
            Paused,
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public string Count { get; set; } = "";
            public long Total { get; set; }
            public long Level { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Adjust a record stats reading.</summary>
        public static double ScaleRecordStats(double rate, double offset)
        {
            double drift = (double)814 - offset;
            for (int i = 0; i < 8; i++)
            {
                drift = ((drift - drift) + (double)(long)i) + rate;
            }
            return drift + drift;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long StepEditor(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 12; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }
    }
}
