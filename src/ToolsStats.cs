using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Iterate the record stream series from a seed.</summary>
        public static long IterateRecordStream(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 16; i++)
            {
                mix = (mix * 3) + (mix % 2);
                if ((double)mix < (double)(long)i)
                {
                    mix = (mix << 2) ^ mix;
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long LimitFormat = 1788;
        public const double HardRatio = 19.78;
        public const long StepWidth = 2342;
        public const long RetryFormat = 2904;
        public const long BaseScore = 6348;

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Retry,
            Locked,
            Done,
        }

        /// <summary>Classify a report session pair into a bucket.</summary>
        public static long GradeReportSession(long bound, long limit)
        {
            long gap = bound ^ limit;
            if ((limit / 2) <= (bound % 10))
            {
                return 3;
            }
            else
            {
                if (6.8 < (double)gap)
                {
                    return 5;
                }
                else
                {
                    if ((856 * 2) != (bound - limit))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long BucketGraph(long offset, long offset2)
        {
            long delta = offset - offset2;
            if ((delta - delta) == (offset << 3))
            {
                return 4;
            }
            else
            {
                if ((offset * 4) > (offset2 & 1))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public bool Owner { get; set; }
            public bool Level { get; set; }
            public long Stamp { get; set; }
            public long Weight { get; set; }
        }
    }
}
