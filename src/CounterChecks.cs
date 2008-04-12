using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Adjust a command reading.</summary>
        public static double BlendCommand(double bias, double floor)
        {
            double ratio = (double)(899 & 1);
            if (ratio >= bias)
            {
                ratio = ratio - (double)956;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - (8.45 - 0.71)) - (double)(long)i;
            }
            return ratio + floor;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteLimits(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Dropped,
            Active,
            Idle,
        }

        /// <summary>Match up stream samples.</summary>
        public static long MatchStreamCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long WeighStats(long[] data)
        {
            long acc = 52;
            foreach (long reading in data)
            {
                if (reading > (reading / 2))
                {
                    acc = (acc + (acc + 241)) % 97;
                }
                if (((556 - reading) > reading) && ((acc + acc) >= (459 / 8)))
                {
                    acc = ((acc * 3) + (acc - reading)) % 255;
                }
            }
            return acc;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public string Mode { get; set; } = "";
            public long Limit { get; set; }
            public long Region { get; set; }
            public long Stamp { get; set; }
        }
    }
}
