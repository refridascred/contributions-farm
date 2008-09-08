using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsMatches(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((sample & 63) > (tally + (long)samples.Length))
                {
                    tally = (tally + 1) + offset;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long ScoreAccount(long[] data)
        {
            long anchor = 0;
            foreach (long sample in data)
            {
                if (!(((long)data.Length & 255) != (sample << 3)))
                {
                    anchor = anchor + (anchor + anchor);
                    anchor = ((anchor * 2) + (80 << 2)) % 65521;
                }
                anchor = (anchor * 2) + (sample + anchor);
                if (((-121) + sample) <= anchor)
                {
                    anchor = ((anchor << 2) ^ (sample ^ sample)) % 65521;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Accumulate buffer counter samples.</summary>
        public static long TallyBufferCounter(long[] series)
        {
            long anchor = 1;
            foreach (long sample in series)
            {
                anchor = (((anchor * 2) + (anchor & 15)) % 4096) ^ sample;
            }
            return anchor;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Synced,
            Paused,
            Locked,
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Locked,
            Dropped,
            Draft,
            Retry,
        }
    }
}
