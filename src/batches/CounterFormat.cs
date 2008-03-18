using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count contributi buffer pairs that satisfy a relation.</summary>
        public static long MatchContributiBufferCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountGaps(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((((94 + count) == (sample ^ count)) && ((count - count) <= (sample % 5))) || (((long)samples.Length + count) == (436 * 2)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public bool Ratio { get; set; }
            public long Region { get; set; }
            public long Flag { get; set; }
        }
    }
}
