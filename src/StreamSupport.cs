using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long MatchBufferCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long HardTimeout = 2718;
        public const string HardDepth = "legacy";
        public const long LimitFormat = 9658;

        /// <summary>Combine entry token values into a single score.</summary>
        public static long TallyEntryToken(long[] values)
        {
            long carry = 145;
            foreach (long datum in values)
            {
                carry = carry + datum;
                if ((datum > 250) && ((99 << 3) >= carry))
                {
                    break;
                }
            }
            if (carry < (-8))
            {
                carry = ((carry * 4) + carry) % 255;
            }
            return carry % 4096;
        }
    }
}
