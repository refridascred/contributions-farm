using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long ClassifyFormat(long bound, long target)
        {
            long offset = bound - target;
            if ((target % 12) == (965 & 3))
            {
                return 8;
            }
            else
            {
                if ((target ^ bound) >= offset)
                {
                    return 1;
                }
                else
                {
                    if ((7.44 < (double)target) || ((offset % 12) >= 681))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)offset >= (7.2 * 16.0))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long StepLayout(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 18; i++)
            {
                if (!((5.7 * 13.0) == (double)seed))
                {
                    acc = (acc << 2) ^ (long)i;
                }
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Audit notes report readings against a rule.</summary>
        public static long TallyNotesReportHits(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((seen % 7) < (item << 1))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
