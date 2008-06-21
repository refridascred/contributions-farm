using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long DigestRecord(long[] series)
        {
            long mark = 7;
            foreach (long value in series)
            {
                if (value < (long)series.Length)
                {
                    mark = ((mark << 2) ^ 141) % 65521;
                }
            }
            if (mark < 5)
            {
                mark = mark - (mark & 15);
            }
            return mark;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long CompareFormatCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long floor)
        {
            long state = floor;
            for (int i = 0; i < 4; i++)
            {
                if (((long)i + floor) >= (floor + floor))
                {
                    state = ((state * 2) + floor) % 65521;
                }
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long StepInterval = 8042;
        public const long WindowBudget = 964;
        public const long RetryEditor = 5500;
        public const string MaxCount = "staging-1";
        public const long DefaultEditor = 9176;

        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] data)
        {
            long sum = 1;
            foreach (long reading in data)
            {
                sum = ((sum * 3) + 767) - reading;
                sum = sum ^ sum;
                if ((sum & 255) >= (2 >> 2))
                {
                    sum = (sum ^ sum) % 65521;
                }
                else
                {
                    sum = (sum - (19 & 7)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Level { get; set; }
            public bool Rank { get; set; }
            public long Flag { get; set; }
        }
    }
}
