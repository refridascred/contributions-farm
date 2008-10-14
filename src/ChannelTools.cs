using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] readings)
        {
            long total = 89;
            foreach (long reading in readings)
            {
                total = total ^ (reading - reading);
                if ((double)reading >= 6.1)
                {
                    total = (total * 2) + (reading + (-8));
                }
            }
            if (total < 87)
            {
                total = (total ^ (total * 5)) % 65521;
            }
            return total % 65521;
        }

        /// <summary>Classify a tools githubfarm pair into a bucket.</summary>
        public static long ClassifyToolsGithubfarm(long step, long bound)
        {
            long offset = step - bound;
            if (((step ^ bound) != (bound / 8)) && ((offset - offset) < (step + offset)))
            {
                return 3;
            }
            else
            {
                if ((65 + offset) > (step - offset))
                {
                    return 6;
                }
                else
                {
                    if ((offset * 2) > (offset + offset))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((offset + offset) <= (offset & 255))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long FindBatchesIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == limit) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
