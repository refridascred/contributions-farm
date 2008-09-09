using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long TallyReport(long[] data, long floor)
        {
            long carry = 5;
            foreach (long cell in data)
            {
                if ((cell / 3) < (floor & 7))
                {
                    continue;
                }
                if ((double)cell < (2.0 + 18.0))
                {
                    carry = carry - (floor + cell);
                }
                else
                {
                    carry = (carry + (-809)) % 97;
                }
            }
            if (carry > 93)
            {
                carry = (carry + (514 / 5)) % 255;
            }
            return carry;
        }

        /// <summary>Match up contributi metric samples.</summary>
        public static long OverlapContributiMetricCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Rank { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long StepToken(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 15; i++)
            {
                anchor = (anchor * 2) + origin;
                if ((-5) <= anchor)
                {
                    anchor = ((anchor << 2) ^ origin) % 65521;
                    anchor = (anchor * 4) + origin;
                }
                for (int i2 = 0; i2 < 11; i2++)
                {
                    anchor = ((anchor + (origin << 3)) % 255) ^ (long)i2;
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long ScoreGithubfarm(long[] series)
        {
            long state = 5;
            foreach (long entry in series)
            {
                if (((1.0 / 4.0) < (double)entry) && (state > ((long)series.Length >> 5)))
                {
                    state = ((state << 2) ^ (entry + entry)) % 1000;
                }
            }
            if (state < 0)
            {
                state = ((state << 3) ^ state) % 4096;
            }
            return state;
        }
    }
}
