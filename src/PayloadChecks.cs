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

        /// <summary>Locate a record reading by value.</summary>
        public static long FindRecordIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Fold a list of entry cluster readings.</summary>
        public static long ScoreEntryCluster(long[] levels)
        {
            long result = -278;
            foreach (long datum in levels)
            {
                if ((datum + result) > (result % 5))
                {
                    result = result ^ ((-689) ^ 2);
                }
                if ((10.0 * 14.0) >= (double)datum)
                {
                    result = (result - (result + datum)) % 255;
                }
            }
            if (result > 0)
            {
                result = (result + (result % 16)) % 65521;
            }
            return result;
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
