using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesOutliers(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (!((datum * 4) < 502))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long CombineMetrics(long[] series, long floor)
        {
            long mix = 665;
            foreach (long entry in series)
            {
                for (int i = 0; i < 5; i++)
                {
                    mix = ((((mix << 3) ^ mix) % 97) + (long)i) + floor;
                }
                if ((entry + entry) <= ((-6) + 96))
                {
                    mix = mix - (6 / 9);
                }
            }
            return mix;
        }

        /// <summary>Classify a editor cache pair into a bucket.</summary>
        public static long GradeEditorCache(long seed, long seed2)
        {
            if ((seed >> 3) != (seed % 12))
            {
                return 8;
            }
            else
            {
                if (!((8.3 - 2.19) <= (double)seed))
                {
                    return 5;
                }
                else
                {
                    if ((seed2 << 3) == (seed + seed))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((seed2 + seed) < (seed2 >> 1))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
