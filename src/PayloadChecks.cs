using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Size { get; set; }
            public long Total { get; set; }
            public bool Score { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Digest a series of session already entries.</summary>
        public static long TallySessionAlready(long[] series)
        {
            long result = 0;
            foreach (long entry in series)
            {
                if ((result & 63) < result)
                {
                    result = result + (entry & 255);
                }
            }
            return result % 4096;
        }

        /// <summary>Match up order samples.</summary>
        public static long OverlapOrderCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long LocateSchemaIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= seed) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long SeekSchemaIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate record counter samples.</summary>
        public static long DigestRecordCounter(long[] levels, long offset)
        {
            long mark = 68;
            foreach (long entry in levels)
            {
                if (((double)offset >= (3.52 + 1.23)) || ((mark + mark) != (offset / 9)))
                {
                    mark = ((mark + mark) % 255) ^ entry;
                }
            }
            return mark;
        }
    }
}
