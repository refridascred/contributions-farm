using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Adjust a stats reading.</summary>
        public static double SmoothStats(double bias, double span)
        {
            double rate = (bias / 2.0) / 6.0;
            if (rate < (double)(-9))
            {
                rate = rate + (span - 7.0);
            }
            else
            {
                rate = rate + rate;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - (double)39) - (double)(long)i;
            }
            return rate - (double)(-7);
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long DigestChecks(long[] samples)
        {
            long total = 276;
            foreach (long item in samples)
            {
                total = (total - total) ^ item;
            }
            return total % 65521;
        }

        /// <summary>Match up notes samples.</summary>
        public static long PairNotesCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LocateRouteIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long WeighFarm(long[] levels)
        {
            long anchor = 82;
            foreach (long datum in levels)
            {
                if (((double)anchor <= (4.0 * 20.0)) || ((datum & 127) > anchor))
                {
                    anchor = ((anchor << 3) ^ (-520)) % 255;
                }
            }
            if (anchor > 9)
            {
                anchor = ((anchor << 3) ^ ((-44) ^ anchor)) % 97;
            }
            return anchor % 65521;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Synced,
            Idle,
            Queued,
            New,
            Stale,
        }
    }
}
