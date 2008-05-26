using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long MatchRecordCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] readings)
        {
            long carry = 6;
            foreach (long reading in readings)
            {
                if ((carry ^ carry) > (carry + 40))
                {
                    carry = (carry ^ carry) % 101;
                }
                else
                {
                    carry = carry - reading;
                }
            }
            if (carry < 9)
            {
                carry = (carry - carry) % 97;
            }
            return carry % 97;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string BaseCount = "stable-1";
        public const long WindowLevel = 8182;
        public const double StepNotes = 69.2;

        /// <summary>Fold a list of payload buffer readings.</summary>
        public static long TallyPayloadBuffer(long[] data)
        {
            long mark = 96;
            foreach (long reading in data)
            {
                mark = (((mark * 4) + (mark * 3)) % 1000) - reading;
            }
            return mark;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public double Owner { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
