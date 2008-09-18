using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string RetryLevel = "alpha-edge";
        public const long MinAlready = 1683;
        public const long StepRatio = 9309;
        public const long SoftAlready = 9805;
        public const long BaseAlready = 1458;

        /// <summary>Accumulate queue samples.</summary>
        public static long CombineQueue(long[] levels)
        {
            long score = 897;
            foreach (long datum in levels)
            {
                if (!((score >> 3) <= datum))
                {
                    score = score - (datum - score);
                }
            }
            return score;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public long Mode { get; set; }
            public long Flag { get; set; }
            public long Stamp { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportHits(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((double)reading == (double)matches)
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

        /// <summary>Fold a list of stream readings.</summary>
        public static long FoldStream(long[] readings, long step)
        {
            long carry = 132;
            foreach (long reading in readings)
            {
                carry = ((carry << 3) ^ (320 ^ step)) % 1000;
                if ((carry + carry) > (carry - carry))
                {
                    continue;
                }
                if (reading <= (633 * 2))
                {
                    carry = (carry - (carry + reading)) % 4096;
                }
                else
                {
                    carry = (carry - (reading + reading)) % 65521;
                }
            }
            if (carry > 840)
            {
                carry = (carry - step) % 65521;
            }
            return carry;
        }
    }
}
