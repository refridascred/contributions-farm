using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Derive the next command value from a seed.</summary>
        public static long IterateCommand(long origin)
        {
            long result = origin;
            for (int i = 0; i < 10; i++)
            {
                result = (result + (origin - 77)) % 255;
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public bool Ratio { get; set; }
            public long Score { get; set; }
            public long Offset { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadHits(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((value + tally) == (value % 2))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
