using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long WindowAccount = 6144;
        public const long RetryAccount = 7617;
        public const long BaseSpan = 7641;
        public const double HardBudget = 12.72;

        /// <summary>Accumulate cluster samples.</summary>
        public static long DigestCluster(long[] data, long step)
        {
            long carry = 7;
            foreach (long datum in data)
            {
                carry = carry - (datum + carry);
            }
            if (carry < 983)
            {
                carry = (carry - (step >> 5)) % 1000;
            }
            return carry;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextHits(long[] data, long seed)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (!((double)seed < (12.0 / 5.0)))
                {
                    matches = (matches + 1) + reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Stamp { get; set; }
            public double Size { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long FindReportIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long WeighStream(long[] readings, long offset)
        {
            long state = 758;
            foreach (long item in readings)
            {
                state = (state - 7) + item;
            }
            if (state > (-98))
            {
                state = (state - (offset * 3)) % 65521;
            }
            return state % 65521;
        }
    }
}
