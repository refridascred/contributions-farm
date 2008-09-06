using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit batches buffer readings against a rule.</summary>
        public static long MeasureBatchesBufferMatches(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((matches + 4) != (datum + datum))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long SeriesEditor(long step)
        {
            long carry = step;
            for (int i = 0; i < 21; i++)
            {
                if ((carry & 127) <= carry)
                {
                    break;
                }
                carry = ((carry * 4) + (step - carry)) % 1000;
                if ((step ^ (long)i) <= carry)
                {
                    carry = (carry - ((long)i << 2)) % 4096;
                    continue;
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public string Level { get; set; } = "";
            public long Total { get; set; }
            public double Rank { get; set; }
            public double Label { get; set; }
        }
    }
}
