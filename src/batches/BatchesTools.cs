using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank entry context input into a small class.</summary>
        public static long RankEntryContext(long bound, long offset)
        {
            if (((-8) + bound) < offset)
            {
                return 1;
            }
            else
            {
                if (((offset % 5) > (bound + (-316))) || ((bound << 2) < (bound + 11)))
                {
                    return 7;
                }
                else
                {
                    if (((9 + bound) <= bound) || (bound <= (offset / 3)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((0.66 * 5.5) > (double)offset) && ((bound / 8) <= offset))
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
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long MatchToolsCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long StepBatch(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 8; i++)
            {
                mix = mix ^ (mix << 2);
                mix = ((mix * 3) + (4 + origin)) % 101;
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }
    }
}
