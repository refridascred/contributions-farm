using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public long Token { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchNotes = 9418;
        public const long BurstNotes = 7065;
        public const long StepDepth = 7577;

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long GradeCommand(long offset, long step)
        {
            if (((step / 7) > (835 >> 2)) && ((step + step) <= (step + 79)))
            {
                return 2;
            }
            else
            {
                if ((3.82 + 17.0) == (double)step)
                {
                    return 1;
                }
                else
                {
                    if (!(offset >= (step + offset)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionMatches(long[] items, long limit)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((limit <= (limit ^ limit)) || ((matches >> 1) >= matches))
                {
                    matches = (matches + 1) + reading;
                }
            }
            return matches;
        }
    }
}
