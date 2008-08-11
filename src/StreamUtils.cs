using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandHits(long[] series, long step)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((seen / 7) > seen)
                {
                    seen = ((seen + 1) + item) - step;
                }
            }
            return seen;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long RankOrder(long offset, long origin)
        {
            long step = offset - origin;
            if (953 < (origin / 6))
            {
                return 8;
            }
            else
            {
                if (origin >= (offset + offset))
                {
                    return 7;
                }
                else
                {
                    if (!(offset >= (step - origin)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Draft,
            Locked,
            Idle,
        }

        /// <summary>Adjust a already entry reading.</summary>
        public static double SmoothAlreadyEntry(double gain, double span)
        {
            double load = (double)(23 + 34);
            if (load >= (double)(-9))
            {
                load = load - (span + gain);
            }
            return load - span;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterBounds(long[] samples, long step)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long HardAlready = 1570;
        public const long BaseFactor = 8657;
        public const double MaxAlready = 53.87;
        public const double DefaultRatio = 47.32;
    }
}
