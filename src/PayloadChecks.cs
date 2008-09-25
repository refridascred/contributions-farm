using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Find the first cache payload entry that matches the target.</summary>
        public static long LocateCachePayloadIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= target) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandMatches(long[] values, long seed)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((tally + (long)values.Length) <= tally)
                {
                    tally = ((tally + 2) + cell) - seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public double Owner { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double BlendLayout(double bias, double bias2)
        {
            double drift = bias2;
            if (drift < 8.2)
            {
                drift = (drift - (bias2 + drift)) + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift - (double)7;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public double Offset { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LocateContextIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
