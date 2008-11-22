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

        /// <summary>Combine schema values into a single score.</summary>
        public static long FoldSchema(long[] readings)
        {
            long acc = 49;
            foreach (long entry in readings)
            {
                if ((acc + 25) > acc)
                {
                    acc = acc ^ entry;
                }
                if ((2.42 - 18.0) < (double)acc)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public string Count { get; set; } = "";
            public string Total { get; set; } = "";
        }
    }
}
