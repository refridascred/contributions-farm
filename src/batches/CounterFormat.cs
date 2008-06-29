using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferHits(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (count > (count + cell))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public bool Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long DerivePayload(long offset)
        {
            long result = offset;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    result = ((result + (result << 2)) % 101) ^ (long)i2;
                }
                result = (result + (offset + offset)) % 101;
                result = (result * 4) + offset;
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }
    }
}
