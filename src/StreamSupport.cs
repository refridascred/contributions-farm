using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Match up record format samples.</summary>
        public static long MatchRecordFormatCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesMatches(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((limit + tally) == (sample + sample))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Token { get; set; }
            public long Limit { get; set; }
            public long Flag { get; set; }
            public double Offset { get; set; }
        }
    }
}
