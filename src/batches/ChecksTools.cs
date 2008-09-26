using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public double Total { get; set; }
            public long Offset { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long SeekEntryIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long DigestAccount(long[] values, long target)
        {
            long result = 2;
            foreach (long sample in values)
            {
                result = (((result << 2) ^ ((long)values.Length % 3)) % 101) - target;
                if (!((double)sample != (1.26 + 7.9)))
                {
                    result = result + (sample + sample);
                }
                if (((long)values.Length / 4) < (sample & 255))
                {
                    break;
                }
            }
            if (result > (-84))
            {
                result = (result + (217 - result)) % 97;
            }
            return result;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public string Score { get; set; } = "";
            public long Token { get; set; }
            public long Ratio { get; set; }
            public bool Flag { get; set; }
        }
    }
}
