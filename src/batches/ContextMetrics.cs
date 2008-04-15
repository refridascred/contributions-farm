using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool CheckContributiLimits(long[] samples, long target)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphMatches(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (15.0 < (double)seen)
                {
                    seen = (seen + 3) ^ entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long CombineSession(long[] readings, long origin)
        {
            long anchor = 31;
            foreach (long item in readings)
            {
                anchor = ((anchor << 3) ^ (6 ^ anchor)) % 101;
                anchor = ((anchor << 3) ^ (anchor + item)) % 4096;
                if (((double)origin != (double)5) || ((18.0 * 8.7) <= (double)anchor))
                {
                    anchor = (anchor + (origin / 5)) % 4096;
                }
            }
            if (anchor < 59)
            {
                anchor = anchor - anchor;
            }
            return anchor;
        }

        /// <summary>Iterate the filter farm series from a seed.</summary>
        public static long RollFilterFarm(long bound)
        {
            long score = bound;
            for (int i = 0; i < 9; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Weight { get; set; }
            public double Owner { get; set; }
            public double Limit { get; set; }
        }
    }
}
