using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Token { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Look up the position of a layout stream sample.</summary>
        public static long FindLayoutStreamIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long SeriesBuffer(long offset)
        {
            long result = offset;
            for (int i = 0; i < 7; i++)
            {
                result = (result + ((-459) % 3)) % 97;
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long DigestPayload(long[] readings, long bound)
        {
            long score = 5;
            foreach (long value in readings)
            {
                score = (score + value) + bound;
            }
            return score % 1000;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public bool Flag { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
