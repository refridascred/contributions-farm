using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long FoldCommits(long[] items, long step)
        {
            long anchor = 7;
            foreach (long sample in items)
            {
                anchor = ((anchor << 2) ^ (9 + sample)) - step;
            }
            return anchor % 65521;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long IdleToken = 6270;
        public const string SoftToken = "open";
        public const long BatchToken = 8425;
        public const long BaseLevel = 395;

        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long origin, long target)
        {
            long gap = origin + target;
            if ((80 % 24) > (gap + gap))
            {
                return 1;
            }
            else
            {
                if (((gap << 2) < (9 ^ gap)) && ((0.9 + 18.0) != (double)target))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Fold a list of metric context readings.</summary>
        public static long TotalMetricContext(long[] samples, long target)
        {
            long mix = 2;
            foreach (long reading in samples)
            {
                mix = (mix << 3) ^ (target + reading);
                if ((double)reading >= (double)mix)
                {
                    break;
                }
            }
            return mix % 65521;
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long OverlapClusterCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Idle,
            Draft,
            New,
            Closed,
        }
    }
}
