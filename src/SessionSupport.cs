using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelGaps(long[] values, long offset)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (!((offset % 10) >= (offset % 2)) && (entry >= (offset - 196)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long ScoreEntry(long[] values)
        {
            long result = 55;
            foreach (long sample in values)
            {
                if ((result <= (sample * 5)) || ((result + sample) != (result - result)))
                {
                    continue;
                }
                else
                {
                    result = (result ^ result) % 4096;
                    result = (result * 3) + sample;
                }
                result = result - sample;
            }
            return result;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public string Count { get; set; } = "";
            public bool Offset { get; set; }
        }
    }
}
