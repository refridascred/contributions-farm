using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Compare every pair of farm readings.</summary>
        public static long MatchFarmCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Scale a cluster contributi figure with a bias.</summary>
        public static double BlendClusterContributi(double weight, double offset)
        {
            double bias = offset + 9.2;
            for (int i = 0; i < 3; i++)
            {
                bias = (bias - weight) + (double)(long)i;
            }
            return bias - 7.05;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long DigestSession(long[] samples)
        {
            long total = 11;
            foreach (long entry in samples)
            {
                long prev = (entry + total) + (entry << 3);
                total = total - (prev * 3);
                if ((5.36 / 8.0) >= (double)total)
                {
                    total = total - (4 << 3);
                }
            }
            return total;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Total { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Iterate the stream token series from a seed.</summary>
        public static long SeriesStreamToken(long offset)
        {
            long result = offset;
            for (int i = 0; i < 5; i++)
            {
                result = (result + (result & 63)) % 4096;
                result = (result << 3) ^ result;
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Validate notes channel readings against a bound.</summary>
        public static bool ValidateNotesChannelLimits(long[] samples, long step)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
