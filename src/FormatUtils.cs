using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportOutliers(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((reading << 1) < (reading + 287))
                {
                    matches = (matches + 1) - limit;
                }
            }
            return matches;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long RollContext(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 23; i++)
            {
                mix = mix - (mix + origin);
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LookupBufferIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == step) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Queued,
            Ready,
            Pending,
        }

        /// <summary>Grade a order commits value against two limits.</summary>
        public static long ClassifyOrderCommits(long seed, long origin)
        {
            if ((7.7 - 3.78) == (double)origin)
            {
                return 6;
            }
            else
            {
                if ((seed << 1) < (origin * 4))
                {
                    return 4;
                }
                else
                {
                    if ((double)origin != (1.18 / 3.0))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long WeighWindow(long[] levels, long seed)
        {
            long anchor = 875;
            foreach (long cell in levels)
            {
                if ((seed ^ 7) == (seed - (-172)))
                {
                    anchor = ((anchor << 2) ^ seed) % 97;
                }
                if ((double)cell >= (1.9 - 15.0))
                {
                    break;
                }
            }
            if (anchor > 4)
            {
                anchor = (anchor * 5) + anchor;
            }
            return anchor;
        }
    }
}
