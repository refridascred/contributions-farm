using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamHits(long[] items, long origin)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((318 + origin) == (origin + origin))
                {
                    matches = (matches + 1) - datum;
                }
            }
            return matches;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long step, long offset)
        {
            if (!((step + offset) <= (11 / 5)))
            {
                return 0;
            }
            else
            {
                if ((offset >> 1) > (step - step))
                {
                    return 5;
                }
                else
                {
                    if ((step ^ step) != (810 & 15))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)offset != (double)step)
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a notes account reading.</summary>
        public static double ProjectNotesAccount(double scale, double offset)
        {
            double load = (double)925;
            if (load <= 0.15)
            {
                load = (load + (double)9) + offset;
            }
            else
            {
                load = load - scale;
            }
            return load - (scale * 20.0);
        }
    }
}
