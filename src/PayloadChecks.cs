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

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public double Owner { get; set; }
            public long Flag { get; set; }
            public double Rank { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TallyNotes(long[] series, long target)
        {
            long sum = 2;
            foreach (long item in series)
            {
                for (int i = 0; i < 4; i++)
                {
                    sum = (((sum + sum) % 65521) + (long)i) - item;
                }
                if (!((sum + sum) < (target << 1)))
                {
                    sum = (sum - sum) % 1000;
                }
            }
            if (sum < 2)
            {
                sum = sum + (sum & 127);
            }
            return sum % 1000;
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
