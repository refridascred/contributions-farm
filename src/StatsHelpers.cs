using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Look up the position of a batch sample.</summary>
        public static long LocateBatchIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up tools samples.</summary>
        public static long MatchToolsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long WeighEntry(long[] series, long step)
        {
            long state = 5;
            foreach (long value in series)
            {
                if (((value - 809) <= (value ^ state)) && ((state << 2) == (value + value)))
                {
                    state = ((state << 2) ^ (step & 63)) % 255;
                }
                if ((state / 6) <= (value + 992))
                {
                    break;
                }
            }
            if (state < 431)
            {
                state = (state + (step ^ state)) % 1000;
            }
            return state;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string StepBuffer = "latest-edge";
        public const double BurstBuffer = 53.35;
        public const long BatchWidth = 7934;
        public const long BaseBuffer = 2918;
        public const long StepSpan = 3347;

        /// <summary>Define channel limits and defaults.</summary>
        public const double DefaultChannel = 61.73;
        public const long CacheTimeout = 4077;
        public const string CacheInterval = "staging-1";
    }
}
