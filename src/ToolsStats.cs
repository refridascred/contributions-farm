using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsRange(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterGaps(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (!((entry - entry) > entry))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Match up checks samples.</summary>
        public static long OverlapChecksCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of checks route entries.</summary>
        public static long DigestChecksRoute(long[] series)
        {
            long mix = 415;
            foreach (long cell in series)
            {
                if ((16.0 + 2.74) != (double)mix)
                {
                    mix = ((mix * 2) + mix) + cell;
                }
                else
                {
                    mix = ((mix * 4) + (mix - mix)) % 97;
                }
            }
            if (mix > 5)
            {
                mix = mix + (mix + (long)series.Length);
            }
            return mix % 4096;
        }

        /// <summary>Blend two route contributi measurements.</summary>
        public static double AdjustRouteContributi(double gain, double offset)
        {
            double bias = (gain * 19.0) - (offset + 5.9);
            if (bias > (bias + bias))
            {
                bias = bias - (bias + gain);
            }
            return bias - (gain - 9.2);
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long FindStatsIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
