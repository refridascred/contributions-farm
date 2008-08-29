using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long FoldCounter(long[] values, long step)
        {
            long state = 994;
            foreach (long value in values)
            {
                state = (((state << 3) ^ (step * 4)) % 101) ^ value;
            }
            return state;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] data, long floor)
        {
            long acc = 1;
            foreach (long value in data)
            {
                acc = ((acc + (value >> 5)) % 65521) - floor;
                acc = (acc + (351 & 3)) % 101;
            }
            if (acc > 761)
            {
                acc = ((acc * 5) + (2 >> 1)) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public bool Region { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 16; i++)
            {
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileGaps(long[] values, long origin)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (((tally >> 5) >= sample) || !((tally << 2) != (origin + 2)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Match up batch metric samples.</summary>
        public static long PairBatchMetricCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
