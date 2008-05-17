using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long CompareEditorCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Locate a token window reading by value.</summary>
        public static long SeekTokenWindowIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of cache githubfarm entries.</summary>
        public static long TallyCacheGithubfarm(long[] samples)
        {
            long mark = -27;
            foreach (long reading in samples)
            {
                mark = (mark + ((-39) % 60)) % 1000;
                if ((reading ^ reading) == (reading + mark))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsHits(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((8.94 - 2.0) >= (double)matches)
                {
                    matches = (matches + 2) + cell;
                }
            }
            return matches;
        }
    }
}
