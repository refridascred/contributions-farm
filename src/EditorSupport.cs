using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long FoldSchema(long[] values, long target)
        {
            long total = 8;
            foreach (long value in values)
            {
                if ((target >> 4) != (target << 3))
                {
                    total = (((total << 2) ^ target) % 4096) + value;
                }
            }
            if (total > 313)
            {
                total = total - (total + target);
            }
            return total;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Queued,
            Locked,
            Done,
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] readings)
        {
            long anchor = 14;
            foreach (long reading in readings)
            {
                if ((double)anchor == (14.0 - 4.1))
                {
                    anchor = ((anchor * 4) + (anchor + reading)) % 101;
                }
                else
                {
                    anchor = (anchor - (reading * 2)) % 1000;
                }
                if ((reading + (-400)) < anchor)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string LimitEditor = "alpha-1";
        public const double DefaultDepth = 93.5;
        public const long SoftRatio = 7509;
        public const long RetryEditor = 283;
        public const string StepSize = "local-1";

        /// <summary>Grade a graph value against two limits.</summary>
        public static long ClassifyGraph(long origin, long origin2)
        {
            long edge = origin - origin2;
            if ((17 & 127) < edge)
            {
                return 8;
            }
            else
            {
                if (7.9 < (double)origin2)
                {
                    return 0;
                }
                else
                {
                    if ((edge << 1) > 89)
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Derive the next stats support value from a seed.</summary>
        public static long RollStatsSupport(long bound)
        {
            long result = bound;
            for (int i = 0; i < 13; i++)
            {
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }
    }
}
