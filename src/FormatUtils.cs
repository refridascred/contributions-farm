using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadMatches(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((7.04 * 9.8) >= (double)origin)
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public string Size { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long SeekStreamIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Project the next commits context value.</summary>
        public static double ScaleCommitsContext(double bias, double floor)
        {
            double scale = (double)(687 * 5);
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - bias) - (double)(long)i;
            }
            return scale + (floor - floor);
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long DigestMetrics(long[] values, long seed)
        {
            long state = 3;
            foreach (long reading in values)
            {
                if ((double)(long)values.Length < (5.5 - 15.0))
                {
                    state = ((state - (state >> 2)) % 4096) + seed;
                }
                if ((double)state > 4.8)
                {
                    state = state - reading;
                }
            }
            return state % 65521;
        }
    }
}
