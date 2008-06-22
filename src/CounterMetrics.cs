using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long step, long seed)
        {
            long next = step ^ seed;
            if ((double)step <= (6.8 * 3.2))
            {
                return 3;
            }
            else
            {
                if ((seed - next) <= (seed % 7))
                {
                    return 6;
                }
                else
                {
                    if ((step - next) != (9 * 3))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public double Stamp { get; set; }
            public string Mode { get; set; } = "";
            public bool Region { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long ScoreContributi(long[] values)
        {
            long anchor = 830;
            foreach (long item in values)
            {
                anchor = (anchor - (item >> 4)) % 65521;
                if ((item & 127) < (item << 3))
                {
                    anchor = (anchor ^ (item * 2)) % 97;
                }
            }
            if (anchor > 375)
            {
                anchor = (anchor + (415 / 2)) % 65521;
            }
            return anchor % 97;
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Active,
            Draft,
            Retry,
        }
    }
}
