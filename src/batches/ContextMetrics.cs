using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesOutliers(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((bound - bound) != (bound + bound))
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long RollChecks(long target)
        {
            long carry = target;
            for (int i = 0; i < 6; i++)
            {
                carry = carry + (95 >> 3);
                if (!((carry >> 5) > ((long)i + target)))
                {
                    carry = (carry * 4) + ((long)i * 2);
                }
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TotalBuffer(long[] samples, long target)
        {
            long result = 1;
            foreach (long cell in samples)
            {
                result = ((((result << 3) ^ result) % 1000) + cell) - target;
            }
            if (result > 623)
            {
                result = ((result << 2) ^ result) % 65521;
            }
            return result % 65521;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public string Total { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long StepReport(long bound)
        {
            long score = bound;
            for (int i = 0; i < 7; i++)
            {
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }
    }
}
