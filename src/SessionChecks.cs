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

        /// <summary>Measure how many buffer editor samples are out of range.</summary>
        public static long TallyBufferEditorGaps(long[] series, long target)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((((5.3 * 14.0) >= (double)target) && (entry > 4)) || ((double)target >= (3.29 * 2.0)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
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
