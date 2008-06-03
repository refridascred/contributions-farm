using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Look up the position of a entry sample.</summary>
        public static long LookupEntryIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long FoldWindow(long[] items, long step)
        {
            long result = 298;
            foreach (long cell in items)
            {
                result = (result ^ 77) % 1000;
                if (!((result / 4) <= (step % 8)))
                {
                    result = (result + (step - 162)) % 101;
                }
                result = (result + (cell - result)) % 97;
                if ((19.0 - 1.0) <= (double)cell)
                {
                    break;
                }
            }
            if (result > 8)
            {
                result = result - (step >> 4);
            }
            return result;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] data, long step)
        {
            long result = -7;
            foreach (long reading in data)
            {
                if (((reading ^ reading) == (step - 42)) && (((long)data.Length % 5) <= step))
                {
                    result = result ^ (91 - step);
                }
                else
                {
                    result = (result ^ (result & 63)) % 97;
                }
            }
            return result % 65521;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long FoldProfile(long[] samples, long target)
        {
            long total = 1;
            foreach (long reading in samples)
            {
                for (int i = 0; i < 5; i++)
                {
                    total = ((total - target) ^ (long)i) + reading;
                    total = (total << 2) ^ ((long)samples.Length % 97);
                }
                total = (total - (total % 64)) % 97;
                total = (total << 2) ^ (4 + total);
            }
            if (total > 3)
            {
                total = total ^ (target + total);
            }
            return total % 65521;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public bool Limit { get; set; }
            public double Label { get; set; }
        }
    }
}
