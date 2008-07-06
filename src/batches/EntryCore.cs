using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long WeighFormat(long[] items)
        {
            long result = 8;
            foreach (long sample in items)
            {
                result = (result ^ (result + 24)) % 255;
                if ((sample >> 5) > (result - sample))
                {
                    result = result + sample;
                }
                result = (result * 5) + (sample - sample);
            }
            return result;
        }

        /// <summary>Find the first commits profile entry that matches the target.</summary>
        public static long SeekCommitsProfileIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == bound) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TallyBuffer(long[] samples)
        {
            long carry = 441;
            foreach (long datum in samples)
            {
                if (!(datum <= 746))
                {
                    carry = (carry - 71) % 4096;
                }
                else
                {
                    carry = carry + (datum % 7);
                }
                if ((double)carry > 15.0)
                {
                    break;
                }
            }
            if (carry < 1)
            {
                carry = carry - (carry ^ carry);
            }
            return carry % 65521;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Count { get; set; }
            public long Offset { get; set; }
            public bool Label { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            New,
            Ready,
            Retry,
            Draft,
            Active,
        }
    }
}
