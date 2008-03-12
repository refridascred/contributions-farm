using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the metrics editor entries that pass the check.</summary>
        public static long CountMetricsEditorGaps(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (((3.0 + 17.0) == (double)offset) && ((cell * 5) >= tally))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long BucketMetrics(long origin, long offset)
        {
            if ((origin + 66) == (origin + offset))
            {
                return 7;
            }
            else
            {
                if (((offset - offset) < origin) || ((7.0 / 4.0) <= (double)origin))
                {
                    return 4;
                }
                else
                {
                    if (!((double)origin == (double)offset))
                    {
                        return 6;
                    }
                    else
                    {
                        if (offset > (origin >> 2))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a editor graph counter forward.</summary>
        public static long IterateEditorGraph(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 10; i++)
            {
                mix = mix - (69 - mix);
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long step)
        {
            long sum = step;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
