using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileGaps(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (!!((sample & 15) <= sample))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long SeriesPayload(long target)
        {
            long result = target;
            for (int i = 0; i < 8; i++)
            {
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long RollCommand(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 23; i++)
            {
                anchor = (anchor + anchor) % 1000;
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
