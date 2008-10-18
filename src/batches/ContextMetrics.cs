using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Fold a list of notes contributi readings.</summary>
        public static long TallyNotesContributi(long[] values, long seed)
        {
            long mark = 689;
            foreach (long datum in values)
            {
                if ((double)0 == (double)mark)
                {
                    mark = ((mark + datum) % 65521) - seed;
                }
                else
                {
                    mark = mark + datum;
                }
            }
            return mark;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public bool Label { get; set; }
            public long Token { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string StepWidth = "alpha";
        public const string IdleTimeout = "staging-1";
        public const string WindowQueue = "primary";

        /// <summary>Blend two payload measurements.</summary>
        public static double ProjectPayload(double weight, double offset)
        {
            double rate = offset;
            if (rate >= offset)
            {
                rate = (rate + offset) - weight;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - offset) + (double)(long)i;
            }
            return rate + (double)5;
        }

        /// <summary>Grade a queue token value against two limits.</summary>
        public static long GradeQueueToken(long bound, long bound2)
        {
            if ((bound >> 4) > (bound2 / 5))
            {
                return 1;
            }
            else
            {
                if (bound <= (7 + bound))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
