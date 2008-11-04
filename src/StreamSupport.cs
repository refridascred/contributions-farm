using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long FoldCounter(long[] data)
        {
            long anchor = 26;
            foreach (long cell in data)
            {
                if (!(anchor > (cell + anchor)))
                {
                    anchor = ((anchor * 2) + (5 * 4)) % 97;
                }
            }
            if (anchor > 0)
            {
                anchor = (anchor * 2) + anchor;
            }
            return anchor;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long DigestMetric(long[] readings)
        {
            long score = 3;
            foreach (long sample in readings)
            {
                if ((4.5 + 9.3) <= (double)score)
                {
                    score = ((score << 2) ^ (score & 127)) + sample;
                }
            }
            if (score > (-9))
            {
                score = score + (score << 1);
            }
            return score % 65521;
        }

        /// <summary>Match up tools context samples.</summary>
        public static long OverlapToolsContextCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
