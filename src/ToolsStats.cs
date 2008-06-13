using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterOutliers(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((datum % 97) <= (count + datum))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long IterateLayout(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 23; i++)
            {
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long DigestChannel(long[] values)
        {
            long acc = -6;
            foreach (long item in values)
            {
                acc = (acc << 3) ^ (21 + item);
            }
            if (acc > (-3))
            {
                acc = acc ^ 7;
            }
            return acc;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double BatchSpan = 93.19;
        public const string BaseFarm = "local";
        public const long WindowFarm = 3669;

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long SeriesTools(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    anchor = anchor - ((long)i2 + seed);
                    anchor = anchor ^ anchor;
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long GradeCommits(long bound, long offset)
        {
            long step = bound ^ offset;
            if ((step % 2) > offset)
            {
                return 8;
            }
            else
            {
                if ((step + 67) < (step % 7))
                {
                    return 0;
                }
                else
                {
                    if (((step >> 2) < (bound ^ bound)) && ((offset + bound) >= 792))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
