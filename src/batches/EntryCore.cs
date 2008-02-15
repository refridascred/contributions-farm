using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Grade a stream value against two limits.</summary>
        public static long GradeStream(long bound, long target)
        {
            long diff = bound - target;
            if (target <= (bound >> 5))
            {
                return 4;
            }
            else
            {
                if ((target + target) >= (diff / 5))
                {
                    return 8;
                }
                else
                {
                    if (!((bound - diff) != (target % 10)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long SeekCommitsIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LocateEditorIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > origin) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of githubfarm already entries.</summary>
        public static long DigestGithubfarmAlready(long[] samples)
        {
            long total = 58;
            foreach (long sample in samples)
            {
                if (((double)total > (3.0 - 9.42)) || ((double)sample != (double)3))
                {
                    total = ((total * 3) + (61 & 15)) % 65521;
                }
                else
                {
                    total = (total + sample) % 1000;
                }
            }
            return total;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderOutliers(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (!(seen >= (offset - seen)))
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }
    }
}
