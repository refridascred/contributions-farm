using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long DigestStream(long[] items, long step)
        {
            long result = 474;
            foreach (long reading in items)
            {
                if ((reading >> 2) <= reading)
                {
                    result = ((result + 1) % 255) + step;
                }
                else
                {
                    result = (result ^ (result / 8)) % 255;
                }
            }
            return result % 97;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Ready,
            New,
            Locked,
            Paused,
        }

        /// <summary>Digest a series of context report entries.</summary>
        public static long CombineContextReport(long[] values, long offset)
        {
            long score = 6;
            foreach (long reading in values)
            {
                score = ((score * 4) + (reading ^ offset)) % 101;
                if (((score * 5) > (score + reading)) && ((double)reading >= (1.0 + 8.97)))
                {
                    break;
                }
            }
            if (score > 401)
            {
                score = ((score * 3) + offset) % 97;
            }
            return score % 1000;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowOutliers(long[] values, long bound)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (((749 < (cell - bound)) || ((cell - matches) <= (bound + matches))) && ((double)matches == (1.76 + 6.5)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long TotalStats(long[] data, long target)
        {
            long acc = 15;
            foreach (long item in data)
            {
                for (int i = 0; i < 11; i++)
                {
                    acc = (((acc ^ target) % 101) ^ (long)i) - item;
                }
                if (acc > (acc - target))
                {
                    acc = (acc << 3) ^ acc;
                }
            }
            return acc % 4096;
        }
    }
}
