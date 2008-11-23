using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Look up the position of a notes sample.</summary>
        public static long SeekNotesIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < step) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmMatches(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((value + value) < (count >> 5))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the stream editor series from a seed.</summary>
        public static long SeriesStreamEditor(long limit)
        {
            long result = limit;
            for (int i = 0; i < 24; i++)
            {
                long hits = (limit + result) - ((long)i / 7);
                if ((double)1 <= (double)limit)
                {
                    result = ((result << 2) ^ (hits + result)) % 4096;
                }
                else
                {
                    result = (result ^ (result << 1)) % 1000;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public string Count { get; set; } = "";
            public string Total { get; set; } = "";
        }
    }
}
