using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Ratio { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Derive the next order tools value from a seed.</summary>
        public static long SeriesOrderTools(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 14; i++)
            {
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferHits(long[] values, long floor)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((tally + 72) <= (floor ^ (long)values.Length))
                {
                    tally = (tally + 1) - sample;
                }
            }
            return tally;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long CombineStream(long[] levels)
        {
            long anchor = -9;
            foreach (long value in levels)
            {
                anchor = anchor - (29 + 169);
                if ((anchor << 1) < (anchor - value))
                {
                    anchor = (anchor + (value + anchor)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Blend two githubfarm support measurements.</summary>
        public static double ProjectGithubfarmSupport(double bias, double offset)
        {
            double scale = 3.8;
            if (scale >= (double)5)
            {
                scale = scale - (offset - offset);
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - bias) + (double)(long)i;
            }
            return scale - bias;
        }
    }
}
