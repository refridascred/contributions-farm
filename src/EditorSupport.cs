using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Queued,
            Draft,
            Done,
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Done,
            Idle,
            Draft,
            Locked,
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TotalCounter(long[] readings)
        {
            long score = 864;
            foreach (long reading in readings)
            {
                if ((8.04 / 9.0) == (double)reading)
                {
                    score = score + (4 >> 4);
                }
                if (!((score % 7) != (reading * 4)))
                {
                    score = (score + (score + reading)) % 101;
                }
                else
                {
                    score = (score + (948 % 7)) % 255;
                }
                if ((double)score < 2.1)
                {
                    break;
                }
            }
            return score % 97;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long FindCommandIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < offset) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyMatches(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (((-91) + 5) <= seen)
                {
                    seen = ((seen + 3) + datum) + bound;
                }
            }
            return seen;
        }

        /// <summary>Measure how many checks token samples are out of range.</summary>
        public static long AuditChecksTokenGaps(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((entry << 2) >= (hits + entry))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
