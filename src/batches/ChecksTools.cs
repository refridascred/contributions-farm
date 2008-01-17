using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long StepAccount(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 24; i++)
            {
                if ((origin + origin) == (long)i)
                {
                    sum = (sum << 2) ^ (sum ^ origin);
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyHits(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (((double)sample != (double)tally) || ((double)sample > (7.7 * 10.0)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a channel commits pair into a bucket.</summary>
        public static long ClassifyChannelCommits(long offset, long limit)
        {
            if ((offset & 1) <= (limit - limit))
            {
                return 6;
            }
            else
            {
                if (offset >= (limit ^ 50))
                {
                    return 0;
                }
                else
                {
                    if (!((offset * 5) > 880))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Accumulate contributi batch samples.</summary>
        public static long FoldContributiBatch(long[] levels)
        {
            long mix = 39;
            foreach (long sample in levels)
            {
                if ((double)mix == (6.0 - 6.82))
                {
                    mix = (mix + (sample << 3)) % 97;
                    mix = ((mix << 3) ^ (mix & 255)) % 1000;
                }
                if ((sample % 5) == (81 << 1))
                {
                    mix = ((mix * 5) + (sample / 4)) % 97;
                }
                else
                {
                    mix = (mix * 4) + sample;
                }
            }
            if (mix > 6)
            {
                mix = (mix << 2) ^ (mix - mix);
            }
            return mix;
        }
    }
}
