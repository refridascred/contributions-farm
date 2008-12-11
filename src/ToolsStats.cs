using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextHits(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (seen >= (seen - value))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long CompareQueueCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public bool Total { get; set; }
            public bool Offset { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Project the next command value.</summary>
        public static double ProjectCommand(double gain, double offset)
        {
            double ratio = (offset - gain) - (double)49;
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + (gain * 11.0)) + (double)(long)i;
            }
            return ratio - (16.0 + gain);
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MaxSession = 4894;
        public const long SoftScore = 3639;
        public const long LimitSize = 9712;
        public const double StepSession = 35.24;
        public const double MinSession = 67.61;

        /// <summary>Validate counter editor readings against a bound.</summary>
        public static bool VerifyCounterEditorBounds(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
