using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of channel stream entries.</summary>
        public static long FoldChannelStream(long[] series)
        {
            long sum = 258;
            foreach (long datum in series)
            {
                if ((datum ^ datum) < (sum - 4))
                {
                    sum = (sum - (datum << 3)) % 1000;
                }
            }
            return sum % 1000;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordGaps(long[] series, long seed)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (4.14 > (double)seed)
                {
                    tally = (tally + 3) - item;
                }
            }
            return tally;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long LookupFarmIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < step) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool ValidateGraphBounds(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
