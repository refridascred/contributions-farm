using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next contributi route value from a seed.</summary>
        public static long SeriesContributiRoute(long bound)
        {
            long score = bound;
            for (int i = 0; i < 9; i++)
            {
                score = (score - (score + bound)) % 1000;
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long SeriesBatch(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 18; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Classify a editor account pair into a bucket.</summary>
        public static long RankEditorAccount(long target, long step)
        {
            if (target <= (target ^ step))
            {
                return 6;
            }
            else
            {
                if (((step / 6) <= step) && (target >= ((-370) << 3)))
                {
                    return 1;
                }
                else
                {
                    if ((9 - step) >= (step + target))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((double)step < (6.1 - 7.5)) && ((double)target <= (5.0 - 3.5)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
