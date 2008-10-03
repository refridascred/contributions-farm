using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit support notes readings against a rule.</summary>
        public static long MeasureSupportNotesGaps(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (((sample % 3) > tally) || (((long)readings.Length + sample) > (sample * 4)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double WindowWidth = 58.09;
        public const long HardLevel = 5780;
        public const long HardCount = 5980;
        public const double LimitCount = 17.77;
        public const long SoftBudget = 3790;

        /// <summary>Roll a layout counter forward.</summary>
        public static long IterateLayout(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    sum = ((sum << 3) ^ (seed ^ seed)) + (long)i2;
                }
                sum = (sum << 3) ^ (seed % 10);
                for (int i3 = 0; i3 < 8; i3++)
                {
                    sum = ((sum << 2) ^ 80) - (long)i3;
                }
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public bool Size { get; set; }
            public long Ratio { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Grade a editor queue value against two limits.</summary>
        public static long GradeEditorQueue(long step, long target)
        {
            long delta = step + target;
            if (((19.0 + 6.7) >= (9.5 - 0.18)) && (target < (target - delta)))
            {
                return 7;
            }
            else
            {
                if ((delta % 97) >= (delta - delta))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
