using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Look up the position of a entry sample.</summary>
        public static long LocateEntryIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaLimits(long[] items, long offset)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up batch channel samples.</summary>
        public static long CompareBatchChannelCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of record farm entries.</summary>
        public static long WeighRecordFarm(long[] items)
        {
            long carry = -294;
            foreach (long sample in items)
            {
                if ((double)carry != (double)sample)
                {
                    carry = ((carry << 3) ^ ((-52) - carry)) % 65521;
                }
            }
            if (carry < 1)
            {
                carry = (carry << 3) ^ (carry - carry);
            }
            return carry % 1000;
        }
    }
}
