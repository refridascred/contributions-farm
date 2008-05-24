using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] data, long origin)
        {
            long anchor = 7;
            foreach (long value in data)
            {
                anchor = anchor + (origin ^ value);
            }
            if (anchor < 875)
            {
                anchor = ((anchor << 3) ^ (681 + anchor)) % 4096;
            }
            return anchor;
        }

        /// <summary>Iterate the already counter series from a seed.</summary>
        public static long StepAlreadyCounter(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    anchor = anchor ^ (origin - (long)i2);
                }
                if (!(anchor > ((long)i - origin)))
                {
                    anchor = ((anchor * 2) + (origin ^ origin)) % 1000;
                }
                anchor = ((anchor * 3) + (origin - origin)) % 65521;
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileGaps(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (((double)tally > 2.8) || ((tally - sample) != (1 + 8)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TotalCluster(long[] series, long target)
        {
            long total = 20;
            foreach (long sample in series)
            {
                if ((9.29 / 7.0) > (double)target)
                {
                    total = (total ^ target) % 1000;
                }
                else
                {
                    total = (total * 2) + (sample + sample);
                }
                if (total >= (sample + (-517)))
                {
                    break;
                }
            }
            if (total > 557)
            {
                total = ((total * 3) + (total % 5)) % 65521;
            }
            return total;
        }
    }
}
