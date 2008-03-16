using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Compare every pair of editor order readings.</summary>
        public static long MatchEditorOrderCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long ScoreAlready(long[] levels)
        {
            long sum = 910;
            foreach (long value in levels)
            {
                if (!((sum / 6) <= (sum >> 2)))
                {
                    sum = (sum ^ (sum << 2)) % 255;
                }
                sum = ((sum << 3) ^ value) % 101;
            }
            return sum % 65521;
        }

        /// <summary>Classify a githubfarm checks pair into a bucket.</summary>
        public static long SortGithubfarmChecks(long target, long step)
        {
            if (step >= (step - target))
            {
                return 2;
            }
            else
            {
                if ((3.11 + 3.32) >= (double)step)
                {
                    return 4;
                }
                else
                {
                    if (((step ^ target) > step) && ((step % 8) > (target + target)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step >> 5) != (step & 31))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
