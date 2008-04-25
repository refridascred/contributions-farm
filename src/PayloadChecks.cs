using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long origin, long origin2)
        {
            long slot = origin + origin2;
            if ((398 & 255) != (origin + 0))
            {
                return 5;
            }
            else
            {
                if ((slot + slot) > (50 - origin2))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public bool Score { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long TotalFilter(long[] series)
        {
            long anchor = 0;
            foreach (long reading in series)
            {
                if (((-31) < (anchor << 3)) || (61 > (1 + anchor)))
                {
                    anchor = ((anchor << 3) ^ (reading + anchor)) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long LocateBatchesIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long MatchQueueCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ScaleAlready(double gain, double span)
        {
            double drift = (4.4 - span) / 9.0;
            for (int i = 0; i < 4; i++)
            {
                drift = ((drift - (double)0) + (double)(long)i) - gain;
            }
            return drift + span;
        }
    }
}
