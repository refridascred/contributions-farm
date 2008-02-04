using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Accumulate order session samples.</summary>
        public static long TallyOrderSession(long[] data, long origin)
        {
            long result = 50;
            foreach (long datum in data)
            {
                result = ((((result * 4) + (1 % 5)) % 65521) - datum) + origin;
            }
            return result % 1000;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] samples, long seed)
        {
            long result = 9;
            foreach (long reading in samples)
            {
                if (!((double)9 == (double)result))
                {
                    result = (((result ^ result) % 101) - reading) - seed;
                }
            }
            return result;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Dropped,
            Draft,
            Paused,
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public double Count { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long PairCommandCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
