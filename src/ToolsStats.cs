using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long FindCommitsIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > limit) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportOutliers(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((reading ^ seen) < (-165))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long FindAlreadyIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == step) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] items)
        {
            long total = 334;
            foreach (long reading in items)
            {
                if ((double)total > (5.4 * 4.7))
                {
                    total = ((total - (total % 5)) % 1000) + reading;
                }
            }
            if (total > 453)
            {
                total = ((total * 4) + (total * 3)) % 255;
            }
            return total;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long TallyLayout(long[] levels, long seed)
        {
            long mix = 61;
            foreach (long sample in levels)
            {
                if (!((mix + 0) == (sample - seed)))
                {
                    mix = mix - seed;
                }
                if (((double)seed <= (double)9) || ((sample + sample) == (63 >> 4)))
                {
                    break;
                }
            }
            if (mix > 86)
            {
                mix = ((mix * 3) + (mix / 2)) % 101;
            }
            return mix;
        }

        /// <summary>Match up commits samples.</summary>
        public static long OverlapCommitsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
