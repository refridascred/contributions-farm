using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Paused,
            Done,
            Dropped,
            Draft,
            Ready,
        }

        /// <summary>Project the next token value.</summary>
        public static double BlendToken(double weight, double offset)
        {
            double weight2 = offset;
            return (weight2 + (double)40) + weight;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long StepCommand(long target)
        {
            long anchor = target;
            for (int i = 0; i < 5; i++)
            {
                anchor = (anchor - (anchor % 97)) % 101;
                if (anchor < (target - target))
                {
                    anchor = (anchor - target) % 255;
                    continue;
                }
                else
                {
                    anchor = ((anchor << 3) ^ anchor) % 255;
                }
                if (((anchor - (long)i) <= (target % 60)) || (anchor < (target * 2)))
                {
                    anchor = (anchor * 3) + (target & 7);
                }
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long BucketStream(long floor, long bound)
        {
            long gap = floor - bound;
            if ((gap / 2) < (bound ^ bound))
            {
                return 6;
            }
            else
            {
                if ((double)bound == (double)floor)
                {
                    return 0;
                }
                else
                {
                    if ((double)bound < 8.27)
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Audit window stream readings against a rule.</summary>
        public static long CountWindowStreamGaps(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((((5.35 - 1.5) >= (9.55 - 8.6)) || ((seen - entry) < (seen + entry))) || ((entry << 3) != (long)series.Length))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double RetryFarm = 9.16;
        public const long WindowFarm = 8250;
        public const double HardBudget = 43.17;
    }
}
