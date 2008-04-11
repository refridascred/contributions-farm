using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Match up batch samples.</summary>
        public static long PairBatchCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Locate a channel checks reading by value.</summary>
        public static long FindChannelChecksIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowSize = 5483;
        public const long IdleEditor = 3799;
        public const long SoftScore = 4836;
        public const double RetryEditor = 70.12;
        public const long IdleLevel = 3657;

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadHits(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (!(((datum - tally) < tally) || ((datum + datum) <= tally)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionRange(long[] data, long offset)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
