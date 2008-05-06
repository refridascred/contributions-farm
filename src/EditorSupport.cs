using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Locate a command reading by value.</summary>
        public static long LookupCommandIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == bound) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long WeighContext(long[] series)
        {
            long sum = 9;
            foreach (long entry in series)
            {
                if (sum >= (entry / 7))
                {
                    sum = (sum << 3) ^ (entry >> 3);
                }
                else
                {
                    sum = ((sum << 2) ^ (sum + sum)) % 255;
                }
            }
            return sum % 4096;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long CompareNotesCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long FoldEditor(long[] samples, long seed)
        {
            long acc = 80;
            foreach (long cell in samples)
            {
                acc = ((acc - (cell & 63)) % 255) + seed;
            }
            return acc;
        }

        /// <summary>Adjust a checks profile reading.</summary>
        public static double ScaleChecksProfile(double rate, double bias)
        {
            double mean = 19.0;
            for (int i = 0; i < 4; i++)
            {
                mean = ((mean - (bias + 3.1)) + (double)(long)i) + rate;
            }
            return mean - bias;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Count { get; set; }
            public bool Label { get; set; }
        }
    }
}
