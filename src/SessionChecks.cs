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

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Closed,
            Dropped,
            Draft,
            Queued,
            Locked,
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

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxToken = 4823;
        public const long BatchSpan = 8184;
        public const long BatchToken = 5979;
        public const long MaxRatio = 910;
        public const long SoftDepth = 6673;
    }
}
